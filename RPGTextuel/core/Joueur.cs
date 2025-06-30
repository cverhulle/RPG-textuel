public class Joueur : Personnage
{
    // On définit un Joueur comme un Personnage à 100PV, 10 de force, 100PV max et dont le nom est laissé libre.
    public Joueur(string nom) : base(nom, 100, 10, 100)
    {
    }
}