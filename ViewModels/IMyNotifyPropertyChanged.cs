using System.ComponentModel;

namespace AvaSty.ViewModels;

public interface IMyNotifyPropertyChanged
{
    public void PropertyChangedEventHandler(object? sender, PropertyChangedEventArgs e);
}