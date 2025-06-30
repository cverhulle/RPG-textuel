public class Player : Character
{
    // On définit un Player comme un Character à 100PV, 10 de force, 100PV max et dont le nom est laissé libre.
    public Player(string name) : base(name, 100, 10, 100)
    {
    }
}