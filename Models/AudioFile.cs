using System;
using System.IO.Compression;

namespace AudioEditor.Models;

public class AudioFile
{
    public string FilePath {get; set;} = string.Empty;
    public string FileName {get; set;} = string.Empty;
    public long FileSize {get; set;}
    public int SampleRate {get; set;}
    public int Channels {get; set;}
    public double Duration {get; set;}
    public string Format {get; set;} = string.Empty;

    public string FormattedDuration()
    {
        return TimeSpan.FromSeconds(Duration).ToString(@"hh\:mm\:ss");
    }

    public string FormattedFileSize
    {
        get
        {
            double size = FileSize;

            if (size < 1024)
            {
                return $"{size:F0} Б";
            }
            size /= 1024;

            if (size < 1024)
            {
                return $"{size:F2} КБ";
            }
            size /= 1024;

            return $"{size:F2} МБ";
        }
    }
}