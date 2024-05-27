namespace ConsoleApp32_Indexers;

public class HttpCookie
{
    private readonly Dictionary<string, string> _dictionary;
    public DateTime Expiry { get; set; }

    public HttpCookie()
    {
        _dictionary = new Dictionary<string, string>();
    }

    //defining the indexer: - it is faster than the other option below to write 2 methods
    public string this[string key]
    {
        get { return _dictionary[key]; }
        set { _dictionary[key] = value; }
    }

    //if we did not had the indexer defined we would need to create 2 methods to access it, GetItem() and SetItem() :
    public void SetItem(string key, string value)
    {
        
    }

    public string GetItem(string key)
    {
        
    }
}