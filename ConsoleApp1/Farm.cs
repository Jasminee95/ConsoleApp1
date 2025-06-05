namespace ConsoleApp1;
public class Farm
{
    public void VelgDyr(List<Dyr> Dyra)
    {
        Console.WriteLine("\nSkriv hvilket av dyret du vil høre lyden til");
        foreach (var dyr in Dyra)
        {
            Console.WriteLine(dyr.Type);
        }
    }
    
    public void FinnDyr(List<Dyr> Dyra){
        
    string valg = Console.ReadLine();
        
        bool dyrFunnet = false;
        
        foreach (var dyr in Dyra)
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