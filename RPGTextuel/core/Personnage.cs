public abstract class Personnage
{
    // On définit les attributs de la classe Personnage.
    private string nom;
    private int vie;
    private int force;
    private int pointsDeVieMax;

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

    // On définit les méthodes set et get pour l'attribut pointsDeVieMax.
    // On utilise Math pour mettre à 0 les points de vie maximum s'ils tombent en négatif.
    public int PointsDeVieMax
    {
        get => pointsDeVieMax;
        set => pointsDeVieMax = Math.Max(0, value);
    }

    // On implémente le constructeur de la classe.
    protected Personnage(string nomPersonnage, int viePersonnage, int forcePersonnage, int pointsDeVieMaxPersonnage)
    {
        nom = nomPersonnage;
        vie = viePersonnage;
        force = forcePersonnage;
        pointsDeVieMax = pointsDeVieMaxPersonnage;
    }

    // On définit la méthode encaisserDegats
    // Elle prend en argument un entier "dégats" et diminue la vie du personnage de ce nombre.
    public virtual void encaisserDegats(int degats)
    {
        Vie -= degats;
        Console.WriteLine($"{Nom} subit {degats} points de dégâts. PV restants : {Vie}");
    }

    // On définit la méthode attaquer.
    public virtual void attaquer(Personnage cible)
    {
        Console.WriteLine($"{Nom} attaque {cible.Nom} pour {Force} points de dégâts !");
        cible.encaisserDegats(Force);
    }
}