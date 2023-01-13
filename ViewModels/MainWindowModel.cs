using System.ComponentModel;

namespace AvaSty.ViewModels;

public class MainWindowViewModel : INotifyPropertyChanged
{
    string buttonText = "Click Me!";

    public string ButtonText
    {
        get => buttonText;
        set
        {
            buttonText = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ButtonText)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void ButtonClicked() => ButtonText = "Hello, Avalonia!";
}