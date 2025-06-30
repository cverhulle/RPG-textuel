public class Joueur : Personnage
{
    // On définit un Joueur comme un Personnage à 100Pv, 10 de force et dont le nom est laissé libre.
    public Joueur(string nom) : base(nom, 100, 10)
    {
    }
}