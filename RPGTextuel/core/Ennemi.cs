public class Ennemi : Personnage
{
    // On construit un ennemi à partir de la classe Personnage
    public Ennemi(string nom, int vie, int force, int pointsDeVieMax) : base(nom, vie, force, pointsDeVieMax)
    {
    }
}