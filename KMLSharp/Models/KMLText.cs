namespace KMLSharp.Models;

public class KMLText : KMLSection
{
    public override string Text { get; }

    public KMLText(string text)
    {
        Text = text;
    }
}