using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using System;
using System.IO;

namespace AudioEditor.Services;

public class FileService
{
    private static string[] SupportedExtensions =
    {
        ".wav",
        ".mp3"
    };

    public async Task<IStorageFile?> OpenAudioFileAsync(Window owner)
    {
        var files = await owner.StorageProvider.OpenFilePickerAsync(
            new FilePickerOpenOptions
            {
                Title = "Открыть аудиофайл",
                AllowMultiple = false,

                FileTypeFilter = new[]
                {
                    new FilePickerFileType("Аудиофайлы")
                    {
                        Patterns = new[] { "*.wav", "*.mp3" }
                    },

                    new FilePickerFileType("WAV")
                    {
                        Patterns = new[] { "*.wav" }
                    },

                    new FilePickerFileType("MP3")
                    {
                        Patterns = new[] { "*.mp3" }
                    }
                }
            });

        if (files.Count == 0)
            return null;

        var file = files[0];

        string extension = Path.GetExtension(file.Name).ToLowerInvariant();

        if (!SupportedExtensions.Contains(extension))
        {
            throw new NotSupportedException("Поддерживаются только файлы WAV и MP3.");
        }

        return file;
    }
}