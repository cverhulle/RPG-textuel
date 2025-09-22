using RPGTextuel.Core;

//////////////////////////////////
// ATTENTION : CLASSE NON UTILISEE 
//////////////////////////////////

namespace RPGTextuel.RandomEvent.Class
{
    /// <summary>
    /// Classe abstraite qui définit la structure d'un évènement aléatoire pour les joueurs.
    /// </summary>
    public abstract class PlayerRandomEventClass
    {
        /// <summary>
        /// Nom de l'évènement aléatoire.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Description de l'évènement aléatoire.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Déclenche l'évènement aléatoire pour un joueur donné.
        /// </summary>
        /// <param name="player">Le joueur affecté par l'évènement.</param>
        public abstract void Trigger(Player player);
    }
}