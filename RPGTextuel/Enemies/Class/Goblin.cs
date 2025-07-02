namespace RPGTextuel
{
    // On crée un sous-type d'ennemi de type Goblin
    public class Goblin : Enemy
    {
        public Goblin(string name, int health, int strength, int maxHealth)
            : base(name, health, strength, maxHealth, EnemyType.Goblin)
        {
        }
    }
}