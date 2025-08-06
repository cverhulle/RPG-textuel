using RPGTextuel.Enemies.EnemyTypes;

namespace RPGTextuel.Enemies.Class
{
    // On crée un sous-type d'ennemi de type GoblinChief
    public class GoblinChief : Enemy
    {
        public GoblinChief(string name, int health, int strength, int maxHealth)
            : base(name, health, strength, maxHealth, EnemyType.GoblinChief, 0.1)
        {
        }

        // Propriété pour afficher le type de l'ennemi.
        public override string DisplayType => "Chef Gobelin";
    }
}