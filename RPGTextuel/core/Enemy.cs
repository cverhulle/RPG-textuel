public class Enemy : Character
{
    // On construit un Enemy à partir de la classe Character
    public Enemy(string name, int health, int strength, int maxHealth) : base(name, health, strength, maxHealth)
    {
    }
}