using AvaSty.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaSty.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private Content _content = new ("test");
    public Content Content => _content;
    string _buttonText = "Click Me!";

    public string ButtonText
    {
        get => _buttonText;
        set => SetProperty(ref _buttonText, value);
    }

    public void ButtonClicked() => ButtonText = "Hello, Avalonia!";
}