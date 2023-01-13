using Avalonia.Controls;
using AvaSty.ViewModels;

namespace AvaSty;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}