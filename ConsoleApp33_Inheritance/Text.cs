namespace ConsoleApp33_Inheritance;

public class Text : PresentationObject
{
    public int FontSize { get; set; }
    public string FontName { get; set; }

    public void AddHyperLink(string url)
    {
        Console.WriteLine("We add a link to " + url);
    }
}