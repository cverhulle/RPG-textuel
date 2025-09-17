using RPGTextuel.Config;
using RPGTextuel.Enemies.EnemyTypes;

namespace RPGTextuel.Enemies.Class
{
    /// <summary>
    /// Représente un ennemi de type Chef Gobelin. 
    /// Hérite de <see cref="Enemy"/> avec des statistiques renforcées.
    /// </summary>
    public class GoblinChief : Enemy
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="GoblinChief"/>.
        /// </summary>
        /// <param name="name">Nom du chef gobelin.</param>
        /// <param name="health">Points de vie actuels.</param>
        /// <param name="strength">Force d’attaque.</param>
        /// <param name="maxHealth">Points de vie maximum.</param>
        /// <param name="criticalHitChance">
        /// Probabilité de coup critique (par défaut : <see cref="GameStatConfig.CriticalHitAugmented"/>).
        /// </param>
        public GoblinChief
        (
            string name,
            int health,
            int strength,
            int maxHealth,
            double criticalHitChance = GameStatConfig.criticalHitAugmented
        )
            : base(name, health, strength, maxHealth, EnemyType.GoblinChief, criticalHitChance)
        {
        }

        /// <summary>
        /// Retourne le type de l’ennemi sous forme lisible.
        /// </summary>
        public override string DisplayType => "Chef Gobelin";

        /// <summary>
        /// Crée une nouvelle instance de <see cref="GoblinChief"/>.  
        /// </summary>
        public override Enemy Clone()
        {
            return new GoblinChief(Name, MaxHealth, Strength, MaxHealth, CriticalHitChance);
        }
    }
}