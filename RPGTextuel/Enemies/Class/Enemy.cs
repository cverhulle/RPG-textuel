using RPGTextuel.Config;
using RPGTextuel.Core.Characters;
using RPGTextuel.Enemies.EnemyTypes;

namespace RPGTextuel.Enemies.Class
{
    public class Enemy : Character
    {

        // On ajoute un champ pour gérer le type de l'ennemi
        public EnemyType type { get; }

        // On construit un Enemy à partir de la classe Character
        public Enemy
        (
            string name,
            int health,
            int strength,
            int maxHealth,
            EnemyType enemyType,
            double criticalHitChance = GameStatConfig.criticalHitByDefault
        )
            : base(name, health, strength, maxHealth,criticalHitChance)
        {
            type = enemyType;
        }

        // Cette méthode retourne le type de l'ennemi.
        // Par défaut, le type est "Ennemi".
        public virtual string DisplayType => "Ennemi";
    }
}