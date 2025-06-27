public class Joueur
{
    public string Nom { get; set; }
    public int Vie { get; set; }
    public int Force { get; set; }

    public Joueur(string nom)
    {
        Nom = nom;
        Vie = 100;
        Force = 10;
    }
}