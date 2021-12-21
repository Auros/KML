namespace KMLSharp.Models;

public class KMLItalicized : KMLSection
{
    public KMLSection Child { get; }
    public override string Text => Child.Text;

    public KMLItalicized(KMLSection child)
    {
        Child = child;
    }
}