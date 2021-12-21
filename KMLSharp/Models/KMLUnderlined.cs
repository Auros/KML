namespace KMLSharp.Models;

public class KMLUnderlined : KMLSection
{
    public KMLSection Child { get; }
    public override string Text => Child.Text;

    public KMLUnderlined(KMLSection child)
    {
        Child = child;
    }
}