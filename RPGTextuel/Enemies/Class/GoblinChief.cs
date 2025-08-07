using RPGTextuel.Config;
using RPGTextuel.Enemies.EnemyTypes;

namespace RPGTextuel.Enemies.Class
{
    // On crée un sous-type d'ennemi de type GoblinChief
    public class GoblinChief : Enemy
    {
        public GoblinChief
        (
            string name,
            int health,
            int strength,
            int maxHealth,
            double criticalHitChance = GameConfig.criticalHitAugmented
        )
            : base(name, health, strength, maxHealth, EnemyType.GoblinChief, criticalHitChance)
        {
        }

        // Propriété pour afficher le type de l'ennemi.
        public override string DisplayType => "Chef Gobelin";
    }
}