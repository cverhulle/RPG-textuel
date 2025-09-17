using RPGTextuel.Config;
using RPGTextuel.Core.Characters;
using RPGTextuel.Items.Class;

namespace RPGTextuel.Core
{
    /// <summary>
    /// Représente le joueur contrôlé par l'utilisateur.
    /// Hérite de <see cref="Character"/> et possède un inventaire.
    /// </summary>
    public class Player : Character
    {
        /// <summary>
        /// Inventaire du joueur, initialisé à vide par défaut.
        /// </summary>
        public Inventory Inventory { get; }

        /// <summary>
        /// Crée un joueur avec un nom et des statistiques par défaut définies dans <see cref="GameStatConfig"/>.
        /// </summary>
        /// <param name="name">Nom du joueur.</param>
        public Player(string name) :
            base(
                name,
                GameStatConfig.playerHealthByDefault,
                GameStatConfig.playerAttackByDefault,
                GameStatConfig.playerHealthByDefault,
                GameStatConfig.criticalHitPlayer
                )
        {
            Inventory = new Inventory(this);
        }
    }
}