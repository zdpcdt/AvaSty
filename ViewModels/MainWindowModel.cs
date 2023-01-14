using System.ComponentModel;
using AvaSty.Models;

namespace AvaSty.ViewModels;

public class MainWindowViewModel : INotifyPropertyChanged
{
    private Content _content = new ("test");
    public Content Content => _content;

    string _buttonText = "Click Me!";

    public string ButtonText
    {
        get => _buttonText;
        set
        {
            _buttonText = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ButtonText)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void ButtonClicked() => ButtonText = "Hello, Avalonia!";
}