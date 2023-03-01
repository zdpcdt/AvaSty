using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaSty.Pages;

public partial class LayoutSample : UserControl
{
    public LayoutSample()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}