using System.Data;
using System.Windows.Forms;

namespace RatioIJ2OL;

public partial class Form1 : Form
{
    private IJCSV? IJCSV = null;

    public Form1()
    {
        InitializeComponent();

        string? startupCsvFile = SampleData.GetSampleCsvFilePath();
        if (startupCsvFile is not null)
            LoadCsv(startupCsvFile);

        nudSelectedRoi.ValueChanged += (s, e) => PopulateRatioData();
        nudSweeps.ValueChanged += (s, e) => PopulateRatioData();
        btnSelectCsv.Click += (s, e) =>
        {
            OpenFileDialog ofd = new() { Filter = "CSV files (*.csv)|*.csv" };
            if (ofd.ShowDialog() == DialogResult.OK)
                LoadCsv(ofd.FileName);
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
    }

    private void PopulateRatioData()
    {
        if (IJCSV is null) return;

        UpdateAnalyzerToReflectGuiOptions();

        int roiIndex = (int)nudSelectedRoi.Value - 1;
        int framesPerIteration = IJCSV.RoiFrameCountPerSweep;

        DataTable dataTable = new();
        dataGridView2.RowHeadersVisible = false;
        dataGridView2.DataSource = dataTable;
        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView2.AllowUserToAddRows = false;

        dataTable.Columns.Add("Time", typeof(float));
        for (int i = 0; i < IJCSV.SweepCount; i++)
        {
            dataTable.Columns.Add($"Sweep {i + 1}", typeof(float));
        }

        for (int i = 0; i < framesPerIteration; i++)
        {
            DataRow dataRow = dataTable.NewRow();
            dataRow.SetField(0, i * IJCSV.FramePeriod);
            for (int sweep = 0; sweep < IJCSV.SweepCount; sweep++)
            {
                int ratioFrame = framesPerIteration * sweep + i;
                dataRow.SetField(1 + sweep, IJCSV.GetRatioValue(ratioFrame, roiIndex));
            }
            dataTable.Rows.Add(dataRow);
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
            double[] values = IJCSV.GetRatioSweep(roiIndex, i);
            var sig = formsPlot1.Plot.Add.Signal(values);
            sig.LineWidth = 2;
            sig.Label = $"ROI {roiIndex + 1}";
        }

        formsPlot1.Plot.ShowLegend(ScottPlot.Alignment.UpperRight);
        formsPlot1.Plot.Axes.Margins(horizontal: 0);
        formsPlot1.Plot.Axes.AutoScale();
        formsPlot1.Refresh();
    }
}
