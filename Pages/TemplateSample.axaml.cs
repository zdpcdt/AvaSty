using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaSty.Pages;

public partial class TemplateSample : UserControl
{
    public TemplateSample()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}