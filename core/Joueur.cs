public class Joueur
{
    // La classe comporte trois attributs
    private string nom;
    private int vie;
    public int force { get; set; }
    
    // On définit les méthodes set et get pour le nom.
    public string Nom
    {
        get => nom;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nom = value;
            else
                Console.WriteLine("Le nom ne peut pas être vide ou null.");
        }
    }

    // On définit les méthodes set et get pour l'attribut vie.
    public int Vie
    {
        get => vie;
        set => vie = Math.Max(0, value);
    }

    // Constructeur de la classe ; La vie est réglée sur 100 et la force sur 10.
    public Joueur(string nomDuJoueur)
    {
        nom = nomDuJoueur;
        vie = 100;
        force = 10;
    }
}