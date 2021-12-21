namespace KMLSharp.Models;

public class KMLHeading : KMLSection
{
    public HeadingSize Size { get; }
    public KMLSection Child { get; }
    public override string Text => Child.Text;

    public KMLHeading(HeadingSize size, KMLSection child)
    {
        Size = size;
        Child = child;
    }
}