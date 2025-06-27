public class Joueur
{   
    // La classe comporte trois attributs
    public string Nom { get; set; }
    public int Vie { get; set; }
    public int Force { get; set; }

    // Constructeur de la classe ; La vie est réglée sur 100 et la force sur 10.
    public Joueur(string nom)
    {
        Nom = nom;
        Vie = 100;
        Force = 10;
    }
}