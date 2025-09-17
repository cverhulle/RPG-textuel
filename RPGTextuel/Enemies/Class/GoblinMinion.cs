using RPGTextuel.Config;
using RPGTextuel.Enemies.EnemyTypes;

namespace RPGTextuel.Enemies.Class
{
    /// <summary>
    /// Représente un ennemi de type Petit Gobelin.
    /// Hérite de <see cref="Enemy"/> avec des statistiques faibles.
    /// </summary>
    public class GoblinMinion : Enemy
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="GoblinMinion"/>.
        /// </summary>
        /// <param name="name">Nom du petit gobelin.</param>
        /// <param name="health">Points de vie actuels.</param>
        /// <param name="strength">Force d’attaque.</param>
        /// <param name="maxHealth">Points de vie maximum.</param>
        /// <param name="criticalHitChance">
        /// Probabilité de coup critique (par défaut : <see cref="GameStatConfig.CriticalHitByDefault"/>).
        /// </param>
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

        /// <summary>
        /// Retourne le type de l’ennemi sous forme lisible.
        /// </summary>
        public override string DisplayType => "Petit Gobelin";

        /// <summary>
        /// Crée une nouvelle instance de <see cref="GoblinMinion"/>.  
        /// </summary>
        public override Enemy Clone()
        {
            return new GoblinMinion(Name, MaxHealth, Strength, MaxHealth, CriticalHitChance);
        }
    }
}