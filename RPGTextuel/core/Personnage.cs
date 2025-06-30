public abstract class Personnage
{
    // On définit les attributs de la classe Personnage.
    private string nom;
    private int vie;
    private int force;

    // On définit les méthodes set et get pour le nom.
    // On rejette les noms "null" ou vide.
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
    // On utilise Math pour mettre à 0 les points de vie s'ils tombent en négatif.
    public int Vie
    {
        get => vie;
        set => vie = Math.Max(0, value);
    }

    // On définit les méthodes set et get pour l'attribut force.
    // On utilise Math pour mettre à 0 les points de force s'ils tombent en négatif.
    public int Force
    {
        get => force;
        set => force = Math.Max(0, value);
    }

    // On implémente le constructeur de la classe.
    protected Personnage(string nomPersonnage, int viePersonnage, int forcePersonnage)
    {
        nom = nomPersonnage;
        vie = viePersonnage;
        force = forcePersonnage;
    }
}