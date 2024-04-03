using System.Data;

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

        nudFramesPerIteration.ValueChanged += (s, e) => PopulateRatioData();
        nudSelectedRoi.ValueChanged += (s, e) => PopulateRatioData();
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
        PopulateRawData();
        PopulateRatioData();
    }

    private void PopulateRawData()
    {
        if (IJCSV is null) return;

        DataTable dataTable = new();
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.DataSource = dataTable;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        dataTable.Columns.Add("Frame", typeof(string));
        for (int i = 0; i < IJCSV.RoiCount; i++)
        {
            dataTable.Columns.Add($"ROI {i + 1}", typeof(double));
        }

        for (int frameIndex = 0; frameIndex < IJCSV.FrameCount; frameIndex++)
        {
            DataRow dataRow = dataTable.NewRow();

            string channel = frameIndex % 2 == 0 ? "R" : "G";
            string frameName = $"{frameIndex + 1}: {channel}";
            dataRow.SetField(0, frameName);

            for (int roiIndex = 0; roiIndex < IJCSV.RoiCount; roiIndex++)
            {
                dataRow.SetField(1 + roiIndex, IJCSV.GetFrameValue(frameIndex, roiIndex));
            }

            dataTable.Rows.Add(dataRow);
        }

        Application.DoEvents();
    }

    private void PopulateRatioData()
    {
        if (IJCSV is null) return;

        int roiIndex = (int)nudSelectedRoi.Value - 1;
        int framesPerIteration = (int)nudFramesPerIteration.Value;

        DataTable dataTable = new();
        dataGridView2.RowHeadersVisible = false;
        dataGridView2.DataSource = dataTable;
        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        dataTable.Columns.Add("Frame", typeof(string));

        int iterations = IJCSV.RatioFrameCount / framesPerIteration;
        for (int i = 0; i < iterations; i++)
        {
            dataTable.Columns.Add($"Iteration {i + 1}", typeof(double));
        }

        for (int i = 0; i < framesPerIteration; i++)
        {
            DataRow dataRow = dataTable.NewRow();
            dataRow.SetField(0, $"{i + 1}");
            for (int iteration = 0; iteration < iterations; iteration++)
            {
                int ratioFrame = (int)nudFramesPerIteration.Value * iteration + i;
                dataRow.SetField(1 + iteration, IJCSV.GetRatioValue(ratioFrame, roiIndex));
            }
            dataTable.Rows.Add(dataRow);
        }

        Application.DoEvents();
    }
}
