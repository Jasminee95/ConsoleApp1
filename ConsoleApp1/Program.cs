using ConsoleApp1;

List<Dyr> dyr = new List<Dyr>
{
    new Dyr("Hund", "Woff"),
    new Dyr("Ku", "Muu"),
    new Dyr("Katt", "Mjao"),
    new Dyr("Fisk", "Blub"),
};

Farm farm = new Farm();
while (true)
{
    farm.VelgDyr(dyr);
    farm.FinnDyr(dyr);
}





// Lag en liste over forskjellige dyr (for eksempel "hund", "katt", "ku", osv.), 
// og la programmet spørre brukeren om å velge et dyr fra listen. 
//     Deretter skal programmet skrive ut en passende lyd for det valgte dyret.