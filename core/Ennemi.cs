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
}