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
    public int RatioFrameCount => FrameCount / ChannelCount;

    public const int ChannelCount = 2;

    public int RoiCount { get; }

    public double[,] Values { get; }

    public int SweepCount { get; set; } = 1;
    public int RoiFrameCountPerSweep => RatioFrameCount / SweepCount;
    public double FramePeriod { get; } = 0.067;

    /// <summary>
    /// Analyze an ImageJ ROI multi-measure CSV file.
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

    public double[] GetRatioAll(int roi)
    {
        double[] ratioValues = new double[RatioFrameCount];
        for (int i = 0; i < ratioValues.Length; i++)
        {
            ratioValues[i] = GetRatioValue(i, roi);
        }
        return ratioValues;
    }

    public double[] GetRatioSweep(int roi, int sweep)
    {
        double[] values = new double[RoiFrameCountPerSweep];

        for (int i = 0; i < values.Length; i++)
        {
            int frameIndex = i + sweep * RoiFrameCountPerSweep;
            values[i] = GetRatioValue(frameIndex, roi);
        }

        return values;
    }
}
