namespace RPGTextuel
{
    // On crée un sous-type d'ennemi de type GoblinMinion
    public class GoblinMinion : Enemy
    {
        public GoblinMinion(string name, int health, int strength, int maxHealth)
            : base(name, health, strength, maxHealth, EnemyType.GoblinMinion)
        {
        }
    }
}