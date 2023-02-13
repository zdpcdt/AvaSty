using Avalonia.Controls;
using AvaSty.ViewModels;

namespace AvaSty.Pages;

public partial class BindingSample : UserControl
{
    public BindingSample()
    {
        InitializeComponent();
        DataContext = new BindingSampleViewModel();
    }
}