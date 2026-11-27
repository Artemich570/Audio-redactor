using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AudioEditor.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OpenFile_Click(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Открытие файла пока не реализовано";
    }

    private void ExportFile_Click(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Экспорт пока не реализован";
    }

    private void Play_Click(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Воспроизведение пока не реализовано";
    }

    private void Pause_Click(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Пауза пока не реализована";
    }

    private void Stop_Click(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Остановка пока не реализована";
    }

    private void Cut_Click(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Обрезка пока не реализована";
    }

    private void FadeIn_Click(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Fade In пока не реализован";
    }

    private void FadeOut_Click(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Fade Out пока не реализован";
    }
}