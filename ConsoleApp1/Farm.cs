namespace ConsoleApp1;
public class Farm
{
    private List<Dyr> _dyrPåFarmen { get; set; }

    public Farm()
    {
        _dyrPåFarmen = new List<Dyr>
        {
            new Dyr("Hund", "Woff"),
            new Dyr("Ku", "Muu"),
            new Dyr("Katt", "Mjao"),
            new Dyr("Fisk", "Blub"),
        };
    }

    public void VelgDyr()
    {
        Console.WriteLine("\nSkriv hvilket av dyret du vil høre lyden til");
        foreach (var dyr in _dyrPåFarmen)
        {
            Console.WriteLine(dyr.Type);
        }
    }
    
    public void FinnDyr(){
        
    string valg = Console.ReadLine();
        
        bool dyrFunnet = false;
        
        foreach (var dyr in _dyrPåFarmen)
        {
            if (valg.ToLower() == dyr.Type.ToLower())
            {
                Console.WriteLine($"\nEn {valg} sier {dyr.Lyd}");
                dyrFunnet = true;
                break;
            }
        }

        if (!dyrFunnet)
        {
            Console.WriteLine("Dyret ble ikke funnet.");
        }
    }
}