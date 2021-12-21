namespace KMLSharp.Models;

public class KMLBolded : KMLSection
{
    public KMLSection Child { get; }
    public override string Text => Child.Text;

    public KMLBolded(KMLSection child)
    {
        Child = child;
    }
}