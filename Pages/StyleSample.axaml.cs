using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaSty.Pages;

public partial class StyleDemo : UserControl
{
    public StyleDemo()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}