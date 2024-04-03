using System.Diagnostics;

namespace RatioIJ2OL;

public static class SampleData
{
    public static string? GetSampleCsvFilePath()
    {
        string networkPath = @"X:\Data\zProjects\Aging Spine\data\2024-04-02-adult\2p\cell3\TSeries-03282024-1506-2676\analysis\Results.csv";
        if (File.Exists(networkPath))
            return networkPath;

        string devPath = "../../../../../dev/sample-data/TSeries-03282024-1506-2677-Results.csv";
        Debug.WriteLine(Path.GetFullPath(devPath));
        if (File.Exists(devPath))
            return devPath;

        return null;
    }
}
