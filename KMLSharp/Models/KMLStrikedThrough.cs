namespace KMLSharp.Models;

public class KMLStrikedThrough : KMLSection
{
    public KMLSection Child { get; }
    public override string Text => Child.Text;

    public KMLStrikedThrough(KMLSection child)
    {
        Child = child;
    }
}
