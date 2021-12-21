namespace KMLSharp.Models;

public class KMLLink : KMLSection
{
    public string URL { get; }
    public string Title { get; }
    public override string Text => Title;

    public KMLLink(string url, string title)
    {
        URL = url;
        Title = title;
    }
}