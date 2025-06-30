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

    // Cette méthode permet d'encaisser des dégats.
    // Elle prend en argument un entier "dégats" et diminue la vie du personnage de ce nombre.
    public virtual void EncaisserDegats(int degats)
    {
        Vie -= degats;
        Console.WriteLine($"{Nom} subit {degats} points de dégâts. PV restants : {Vie}");
    }

    // Cette méthode permet d'infliger des dégats à un autre personnage.
    public virtual void Attaquer(Personnage cible)
    {
        Console.WriteLine($"{Nom} attaque {cible.Nom} pour {Force} points de dégâts !");
        cible.EncaisserDegats(Force);
    }

    // Cette méthode indique si le personnage peut recevoir des soins.
    public bool PeutRecevoirSoin(int soin)
    {
        return soin > 0 && Vie < PointsDeVieMax;
    }

    // Cette méthode permet de gérer le calcul des soins.
    // Elle retourne le montnant de soin effectif.
    protected int AppliquerSoin(int soin)
    {
        // On mémorise l'ancien nombre de PV.
        int ancienneVie = Vie;

        // On augmente la vie du personnage
        Vie += soin;

        // Si l'on dépasse les PVmax, on ajuste le montant
        if (Vie > PointsDeVieMax)
            Vie = PointsDeVieMax;

        // On calcule les soins effectifs et, on retourne cette valeur.
        return Vie - ancienneVie;
    }

    // Cette méthode permet de se soigner de "soin" PV.
    public virtual void Soigner(int soin)
    {
        // Si le soin est négatif, ...
        if (soin <= 0)
        {
            // On affiche un message et, on ne fait rien
            Console.WriteLine($"{Nom} ne peut pas être soigné avec {soin} PV.");
            return;
        }

        // On mémorise l'ancien nombre de PV.
        int ancienneVie = Vie;

        // On augmente la vie du personnage
        Vie += soin;


        // Si l'on dépasse les PVmax, on ajuste le montant
        if (Vie > PointsDeVieMax)
            Vie = PointsDeVieMax;

        // On affiche un message à l'utilisateur.
        int soinEffectif = Vie - ancienneVie;
        Console.WriteLine($"{Nom} récupère {soinEffectif} points de vie. PV actuels : {Vie}");
    }
}