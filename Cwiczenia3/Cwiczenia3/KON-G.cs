namespace Cwiczenia3;

public class KON_G : Kontener
{

    private double cisnienie_kontenera;
    
    
    
    public KON_G(double masaladunku, double wyskokosc, double wagawlasna, double glebokosc, string numerseryjny, double maksymalnaladownosc, double cisnienie) : base(masaladunku, wyskokosc, wagawlasna, glebokosc, numerseryjny, maksymalnaladownosc)
    {
        this.cisnienie_kontenera = cisnienie;
    }
    
    
    
    
    
    
    
    
    
   
    
    // jeśli masa ładunku przekroczy dopuszczalną ładowność - zwróć błąd
    
    
}