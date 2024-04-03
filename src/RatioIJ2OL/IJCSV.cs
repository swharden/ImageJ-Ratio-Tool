namespace RatioIJ2OL;

public class IJCSV
{
    /// <summary>
    /// Total number of images across all channels/sections/times/series
    /// </summary>
    public int FrameCount { get; }

    /// <summary>
    /// Number of frames assuming every frame has paired red and green channels
    /// </summary>
    public int RatioFrameCount => FrameCount / 2;

    public int RoiCount { get; }

    public double[,] Values { get; }

    /// <summary>
    /// Analyze an ImageJ ROI mult-measure CSV file.
    /// </summary>
    public IJCSV(string path)
    {
        string[] lines = File.ReadAllLines(path);

        // skip header
        lines = lines[1..];

        FrameCount = lines.Length;
        RoiCount = lines[0].Split(",").Length - 1;
        Values = new double[FrameCount, RoiCount];

        for (int i = 0; i < FrameCount; i++)
        {
            double[] lineValues = lines[i].Split(",").Skip(1).Select(double.Parse).ToArray();
            for (int j = 0; j < RoiCount; j++)
            {
                Values[i, j] = lineValues[j];
            }
        }
    }

    public double GetFrameValue(int frame, int roi)
    {
        return Values[frame, roi];
    }

    public double GetRatioValue(int ratioFrame, int roi)
    {
        double r = Values[ratioFrame * 2, roi];
        double g = Values[ratioFrame * 2 + 1, roi];
        return g / r;
    }
}
