namespace Cwiczenia3;

public class KON_L : Kontener // kontener na płyn pozwala na przewozenie ladunku niebezpiecznego (np. paliwo) i ładunku zwykłego (np. mleko).

{
    public KON_L(double masaladunku, double wyskokosc, double wagawlasna, double glebokosc, string numerseryjny, double maksymalnaladownosc) : base(masaladunku, wyskokosc, wagawlasna, glebokosc, numerseryjny, maksymalnaladownosc)
    {
   
        
        
        
        
    }
    
    public interface IHazardNotifier
    {
        void Notify(string msg);
    }
    
    public void Notify(string message)
    {
        Console.WriteLine("Uwaga! Zdarzenie niebezpieczne kontenera o numerze seryjnym: "+ numer_seryjny + message);
    }
    
    public string Zaladunek_Kontenera(Kontener kontener) // w przypadku przechowywania niebezpiecznego ładunku kontener można wypełnić maksymalnie do 50% jego pojemności w innych przypadkach można wypełnić do 90%.
                                                         // Jeżeli jaka kolwiek z opisanych reguł zostanie naruszona - program informuje użytkownika o próbie wykonania niebezpiecznej operacji.
    
    {
        


        return "Kontener o numerze seryjnym" + numer_seryjny + " został załadowany.";
    }
    
    
}