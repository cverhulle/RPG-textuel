using RPGTextuel.Config;
using RPGTextuel.Enemies.EnemyTypes;

namespace RPGTextuel.Enemies.Class
{
    /// <summary>
    /// Représente un ennemi de type Gobelin.
    /// Hérite de <see cref="Enemy"/>.
    /// </summary>
    public class Goblin : Enemy
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Goblin"/>.
        /// </summary>
        /// <param name="name">Nom du gobelin.</param>
        /// <param name="health">Points de vie actuels.</param>
        /// <param name="strength">Force d’attaque.</param>
        /// <param name="maxHealth">Points de vie maximum.</param>
        /// <param name="criticalHitChance">
        /// Probabilité de coup critique (par défaut : <see cref="GameStatConfig.CriticalHitByDefault"/>).
        /// </param>
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

        /// <summary>
        /// Retourne le type de l’ennemi sous forme lisible.
        /// </summary>
        public override string DisplayType => "Gobelin";

        /// <summary>
        /// Crée une copie de <see cref="Goblin"/>.  
        /// </summary>
        public override Enemy Clone()
        {
            return new Goblin(Name, MaxHealth, Strength, MaxHealth, CriticalHitChance);
        }
    }
}