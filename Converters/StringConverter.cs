using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;

namespace AvaSty.Converters;

public class StringConverter : IValueConverter
{
    public string Prefix { get; set; }

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string s)
        {
            return Prefix + s;
        }

        return AvaloniaProperty.UnsetValue;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}