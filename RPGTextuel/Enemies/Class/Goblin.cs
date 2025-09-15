using RPGTextuel.Config;
using RPGTextuel.Enemies.EnemyTypes;

namespace RPGTextuel.Enemies.Class
{
    // On crée un sous-type d'ennemi de type Goblin
    public class Goblin : Enemy
    {
        // Constructeur de la classe
        public Goblin
        (
            string name,
            int health,
            int strength,
            int maxHealth,
            double criticalHitChance = GameStatConfig.criticalHitByDefault
        )
            : base(name, health, strength, maxHealth, EnemyType.Goblin, criticalHitChance)
        {
        }

        // Propriété pour afficher le type de l'ennemi.
        public override string DisplayType => "Gobelin";

        // On réécrit la méthode Clone.
        public override Enemy Clone()
        {
            return new Goblin(Name, MaxHealth, Strength, MaxHealth, CriticalHitChance);
        }
    }
}