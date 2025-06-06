namespace ConsoleApp1;
public class Dyr
{
    private string _type;
    private string _lyd;

    public Dyr(string type, string lyd)
    {
        _type = type;
        _lyd = lyd;
    }

    public string Type => _type;
    
    public string Lyd => _lyd;
}