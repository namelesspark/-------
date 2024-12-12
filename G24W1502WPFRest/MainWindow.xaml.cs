using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace G24W1502WPFRest;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private GameViewModel vm = new GameViewModel();

    public MainWindow()
    {
        InitializeComponent();

        DataContext = vm;

        GameGrid.ItemsSource = vm.Games;

        InitializeGames();
    }

    private async void InitializeGames()
    {
        await vm.GetGames();
    }

    public void StartWebBrowser(object sender, EventArgs e)
    {
        string url = (string)((Button)sender).Tag;
        Process.Start(
            new ProcessStartInfo("cmd", $"/c start {url}")
            {
                CreateNoWindow = true
            }
        );
    }
}