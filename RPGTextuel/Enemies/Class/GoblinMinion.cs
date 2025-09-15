using RPGTextuel.Config;
using RPGTextuel.Enemies.EnemyTypes;

namespace RPGTextuel.Enemies.Class
{
    // On crée un sous-type d'ennemi de type GoblinMinion
    public class GoblinMinion : Enemy
    {
        public GoblinMinion
        (
            string name,
            int health,
            int strength,
            int maxHealth,
            double criticalHitChance = GameStatConfig.criticalHitByDefault
        )
            : base(name, health, strength, maxHealth, EnemyType.GoblinMinion, criticalHitChance)
        {
        }

        // Propriété pour afficher le type de l'ennemi.
        public override string DisplayType => "Petit Gobelin";

        // On réécrit la méthode CLone.
        public override Enemy Clone()
        {
            return new GoblinMinion(Name, MaxHealth, Strength, MaxHealth, CriticalHitChance);
        }
    }
}