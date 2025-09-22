using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;

namespace RPGTextuel.RandomEvent.Class.Interface
{
    /// <summary>
    /// Interface qui définit la structure générique d'un évènement aléatoire.
    /// </summary>
    public interface IRandomEvent
    {
        /// <summary>
        /// Nom de l'évènement.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Description de l'évènement.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Déclenche l'évènement.
        /// </summary>
        /// <param name="player">Le joueur concerné par l'évènement, ou <c>null</c> si aucun.</param>
        /// <param name="enemy">L'ennemi concerné par l'évènement, ou <c>null</c> si aucun.</param>
        void Trigger(Player? player = null, Enemy? enemy = null);
    }
}