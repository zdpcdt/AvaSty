namespace AvaSty.Models.Server;

public record ServerMetaData
{
    public string? IPAddress { get; set; }
    public int Port { get; set; }
    public int ListeningNum { get; set; }
}