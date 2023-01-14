namespace AvaSty.Models;

public class Content
{
    private string _header = "头";
    public string Header
    {
        get => _header;
        set =>_header = value;
    }

    public Content(string header)
    {
        Header = header;
    }
}