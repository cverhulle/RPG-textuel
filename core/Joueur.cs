public class Joueur
{   
    // La classe comporte trois attributs
    public string Nom { get; set; }
    private int Vie { get; set; }
    public int Force { get; set; }

    // On définit les méthodes set et get pour l'attribut vie.
    public int Vie
    {
        get => vie;
        set => vie = Math.Max(0, value); 
    }

    // Constructeur de la classe ; La vie est réglée sur 100 et la force sur 10.
    public Joueur(string nom)
    {
        Nom = nom;
        Vie = 100;
        Force = 10;
    }
}