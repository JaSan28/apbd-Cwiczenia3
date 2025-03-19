namespace Cwiczenia3;

public class Kontener
{
    private double masa_ladunku { get; set; } // w kilogramach
    private double wyskokosc { get; set; } // w centymetrach
    private double waga_wlasna { get; set; } // waga samego kontenera w kilogramach
    private double glebokosc { get; set; } // w centymetrach
    internal string numer_seryjny { get; set; } // Format numeru to: KON-C-1 | 1 człon to zawsze kon| 2 człon reprezentacja rodzaju kontenera | 3 człon numer generowany przez system uniklany.
    private double maksymalna_ladownosc { get; set; } // maksymalna ladownosc kontenera


    public Kontener(double masaladunku, double wyskokosc, double wagawlasna, double glebokosc, string numerseryjny, double maksymalnaladownosc)
    {
        this.masa_ladunku = masaladunku;
        this.wyskokosc = wyskokosc;
        this.waga_wlasna = wagawlasna;
        this.glebokosc = glebokosc;
        this.numer_seryjny = numerseryjny;
        this.maksymalna_ladownosc = maksymalnaladownosc;
    }



    public string Zaladunek_Kontenera(Kontener kontener)
    {



        return "Kontener o numerze seryjnym" + numer_seryjny + " został załadowany.";
    }
    
    public string Oproznij_Ladunek(Kontener Kontener_z_ladunkeim)
    {
        
        
        
        return "Ładunek z Kontenera o numerze seryjnym: " + numer_seryjny + " został opróżniony.";
    }
    
    
    
}


