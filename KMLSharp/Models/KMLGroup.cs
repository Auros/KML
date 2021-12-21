using System.Text;

namespace KMLSharp.Models;

public class KMLGroup : KMLSection
{
    public override string Text { get; }

    public KMLSection[] Children { get; }

    public KMLGroup(params KMLSection[] children)
    {
        Children = children;
        StringBuilder sb = new();
        foreach (var child in children)
            sb.Append(child.Text);
        Text = sb.ToString();
    }
}