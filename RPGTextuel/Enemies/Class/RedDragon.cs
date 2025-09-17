using RPGTextuel.Config;

namespace RPGTextuel.Enemies.Class
{
    /// <summary>
    /// Représente un ennemi de type Dragon Rouge.
    /// Ennemi puissant avec des statistiques élevées.
    /// </summary>
    public class RedDragon : Enemy
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="RedDragon"/>.
        /// </summary>
        /// <param name="name">Nom du dragon rouge.</param>
        /// <param name="health">Points de vie actuels.</param>
        /// <param name="strength">Force d’attaque.</param>
        /// <param name="maxHealth">Points de vie maximum.</param>
        /// <param name="criticalHitChance">
        /// Probabilité de coup critique (par défaut : <see cref="GameStatConfig.CriticalHitAugmented"/>).
        /// </param>
        public RedDragon
        (
            string name,
            int health,
            int strength,
            int maxHealth,
            double criticalHitChance = GameStatConfig.criticalHitAugmented
        )
            : base(name, health, strength, maxHealth, EnemyTypes.EnemyType.RedDragon, criticalHitChance)
        {
        }

        /// <summary>
        /// Retourne le type de l’ennemi sous forme lisible.
        /// </summary>
        public override string DisplayType => "Dragon Rouge";

        /// <summary>
        /// Crée une nouvelle instance de <see cref="RedDragon"/>.  
        /// </summary>
        public override Enemy Clone()
        {
            return new RedDragon(Name, MaxHealth, Strength, MaxHealth, CriticalHitChance);
        }
    }
}