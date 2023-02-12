using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaSty.Pages;

public partial class BindingSample : UserControl
{
    public BindingSample()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}