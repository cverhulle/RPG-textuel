public class Ennemi
{
    // On définit les attributs de la classe
    private string nom;
    private int vie;
    private int force;

    // On définit les méthodes set et get pour le nom.
    public string Nom
    {
        get => nom;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nom = value;
            else
                Console.WriteLine("Le nom de l'ennemi ne peut pas être vide ou null.");
        }
    }

    // Propriété pour la vie (lecture seule de l'extérieur)
    public int Vie
    {
        get => vie;
        set => vie = Math.Max(0, value);
    }

    // On définit les méthodes set et get pour l'attribut force.
    public int Force
    {
        get => force;
        set => force = value;
    }
}