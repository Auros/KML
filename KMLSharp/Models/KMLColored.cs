namespace KMLSharp.Models;

public class KMLColored : KMLSection
{
    public Color Color { get; }
    public KMLSection Child { get; }
    public override string Text => Child.Text;

    public KMLColored(Color color, KMLSection child)
    {
        Color = color;
        Child = child;
    }
}