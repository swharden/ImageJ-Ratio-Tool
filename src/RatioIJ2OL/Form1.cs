using ScottPlot;
using System.Data;
using System.Windows.Forms;

namespace RatioIJ2OL;

public partial class Form1 : Form
{
    private IJCSV? IJCSV = null;

    public Form1()
    {
        InitializeComponent();
        AllowDrop = true;

        string? startupCsvFile = SampleData.GetSampleCsvFilePath();
        if (startupCsvFile is not null)
            LoadCsv(startupCsvFile);

        nudSweeps.ValueChanged += (s, e) => PopulateRatioData();
        nudSelectedRoi.ValueChanged += (s, e) => PopulateRatioData();
        nudBaseline1.ValueChanged += (s, e) => PopulateRatioData();
        nudBaseline2.ValueChanged += (s, e) => PopulateRatioData();
        btnSelectCsv.Click += (s, e) =>
        {
            OpenFileDialog ofd = new() { Filter = "CSV files (*.csv)|*.csv" };
            if (ofd.ShowDialog() == DialogResult.OK)
                LoadCsv(ofd.FileName);
        };

        DragEnter += (o, e) =>
        {
            if (e.Data is null) return;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        };

        DragDrop += (o, e) =>
        {
            if (e.Data is null) return;
            if (e.Data.GetData(DataFormats.FileDrop) is not string[] paths) return;
            foreach (string path in paths)
                LoadCsv(path);
        };
    }

    public void LoadCsv(string path)
    {
        IJCSV = new(path);
        nudSelectedRoi.Value = 1;
        nudSelectedRoi.Minimum = 1;
        nudSelectedRoi.Maximum = IJCSV.RoiCount;
        PopulateRatioData();
    }

    private void UpdateAnalyzerToReflectGuiOptions()
    {
        if (IJCSV is null) return;

        IJCSV.SweepCount = (int)nudSweeps.Value;
        IJCSV.BaselineTime1 = (double)nudBaseline1.Value;
        IJCSV.BaselineTime2 = (double)nudBaseline2.Value;

        if (nudBaseline1.Value > nudBaseline2.Value)
            nudBaseline2.Value = nudBaseline1.Value;
    }

    private void PopulateRatioData()
    {
        if (IJCSV is null) return;

        UpdateAnalyzerToReflectGuiOptions();

        int roiIndex = (int)nudSelectedRoi.Value - 1;
        int framesPerIteration = IJCSV.RoiFrameCountPerSweep;

        DataTable dataTable = new();
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.DataSource = dataTable;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView1.AllowUserToAddRows = false;

        dataTable.Columns.Add("Time", typeof(float));
        for (int i = 0; i < IJCSV.SweepCount; i++)
        {
            dataTable.Columns.Add($"Sweep {i + 1}", typeof(float));
        }

        for (int i = 0; i < framesPerIteration; i++)
        {
            DataRow dataRow = dataTable.NewRow();
            dataRow.SetField(0, i * IJCSV.FramePeriod);
            dataTable.Rows.Add(dataRow);
        }

        for (int x = 0; x < IJCSV.SweepCount; x++)
        {
            double[] values = IJCSV.GetDffSweep(roiIndex, x);
            for (int y = 0; y < values.Length; y++)
            {
                dataGridView1[x + 1, y].Value = values[y];
            }
        }

        PlotRatioData();
        Application.DoEvents();
    }

    private void PlotRatioData()
    {
        if (IJCSV is null) return;

        formsPlot1.Plot.Clear();

        int roiIndex = (int)nudSelectedRoi.Value - 1;

        for (int i = 0; i < IJCSV.SweepCount; i++)
        {
            double[] values = IJCSV.GetDffSweep(roiIndex, i);
            var sig = formsPlot1.Plot.Add.Signal(values, IJCSV.FramePeriod);
            sig.LineWidth = 2;
            sig.Label = $"Sweep {roiIndex + 1}";
        }

        var gs = formsPlot1.Plot.Add.HorizontalSpan(IJCSV.BaselineTime1, IJCSV.BaselineTime2, Colors.Black.WithAlpha(.1));
        gs.LineStyle.Color = Colors.Transparent;

        formsPlot1.Plot.Add.HorizontalLine(0, 1, Colors.Black, LinePattern.Dashed);

        formsPlot1.Plot.ShowLegend(Alignment.UpperRight);
        formsPlot1.Plot.Axes.Margins(horizontal: 0);
        formsPlot1.Plot.Axes.AutoScale();
        formsPlot1.Plot.XLabel("Time (seconds)");
        formsPlot1.Plot.YLabel("ΔF/F (%)");
        formsPlot1.Plot.Title($"{IJCSV.Filename} ROI #{roiIndex + 1}");
        formsPlot1.Refresh();
    }
}
