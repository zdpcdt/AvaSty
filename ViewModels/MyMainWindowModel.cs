using System.ComponentModel;

namespace AvaSty.ViewModels;

public class MyMainWindowViewModel
{
    string buttonText = "Click Me!";

    public string ButtonText
    {
        get => buttonText;
        set
        {
            buttonText = value;
            MyINotifyPropertyChanged?.PropertyChangedEventHandler(this, new PropertyChangedEventArgs(nameof(ButtonText)));
        }
    }

    private IMyNotifyPropertyChanged? MyINotifyPropertyChanged;

    public void ButtonClicked() => ButtonText = "Hello, Avalonia!";
}