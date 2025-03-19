namespace Cwiczenia3;

public interface IHazardNotifier
{
    {
        void Notify(string msg);
    }
    
    public void Notify(string message)
    {
        Console.WriteLine("Uwaga! Zdarzenie niebezpieczne kontenera o numerze seryjnym: "+ numer_seryjny + message);
    }

    string numer_seryjny { get; }
}