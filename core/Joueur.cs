public class Joueur
{   
    // La classe comporte trois attributs
    public string Nom { get; set; }
    private int Vie;
    public int Force { get; set; }

    // On définit les méthodes set et get pour l'attribut vie.
    public int Vie
    {
        get => Vie;
        set => Vie = Math.Max(0, value); 
    }

    // Constructeur de la classe ; La vie est réglée sur 100 et la force sur 10.
    public Joueur(string nom)
    {
        Nom = nom;
        Vie = 100;
        Force = 10;
    }
}