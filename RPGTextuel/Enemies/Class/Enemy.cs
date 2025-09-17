using RPGTextuel.Config;
using RPGTextuel.Core.Characters;
using RPGTextuel.Enemies.EnemyTypes;

namespace RPGTextuel.Enemies.Class
{
    public class Enemy : Character
    {

        /// <summary>
        /// Représente un ennemi générique du jeu. 
        /// Hérite de <see cref="Character"/> et possède un type spécifique (<see cref="EnemyType"/>).
        /// </summary>
        
        /// <summary>
        /// Type de l’ennemi (<see cref="EnemyType"/>).
        /// </summary>
        public EnemyType type { get; }

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Enemy"/>.
        /// </summary>
        /// <param name="name">Nom de l’ennemi.</param>
        /// <param name="health">Points de vie actuels.</param>
        /// <param name="strength">Force d’attaque.</param>
        /// <param name="maxHealth">Points de vie maximum.</param>
        /// <param name="enemyType">Type d’ennemi.</param>
        /// <param name="criticalHitChance">
        /// Chance de coup critique (par défaut : <see cref="GameStatConfig.CriticalHitByDefault"/>).
        /// </param>
        public Enemy
        (
            string name,
            int health,
            int strength,
            int maxHealth,
            EnemyType enemyType,
            double criticalHitChance = GameStatConfig.criticalHitByDefault
        )
            : base(name, health, strength, maxHealth, criticalHitChance)
        {
            type = enemyType;
        }

        /// <summary>
        /// Retourne le type de l’ennemi sous forme lisible. 
        /// Peut être redéfini dans une classe dérivée (par ex. <c>Goblin</c>, <c>RedDragon</c>, etc.).
        /// </summary>
        public virtual string DisplayType => "Ennemi";

        /// <summary>
        /// Crée une copie de cet ennemi.  
        /// </summary>
        public virtual Enemy Clone()
        {
            return new Enemy(Name, MaxHealth, Strength, MaxHealth, type, CriticalHitChance);
        }
    }
}