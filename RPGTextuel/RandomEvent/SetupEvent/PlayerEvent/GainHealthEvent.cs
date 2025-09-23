using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    /// <summary>
    /// Événement aléatoire : fait gagner des points de vie au joueur.
    /// </summary>
    public class GainHealthEvent : IRandomEvent
    {
        /// <summary>
        /// Nom de l'événement.
        /// </summary>
        public string Name => "Délicieux repas";

        /// <summary>
        /// Description de l'événement.
        /// </summary>
        public string Description => "Ce délicieux repas vous fait regagner des points de vie !";

        /// <summary>
        /// Déclenche l'événement : le joueur regagne entre 10 et 30 PV.
        /// </summary>
        /// <param name="player">Le joueur concerné par l'événement (peut être <c>null</c>).</param>
        /// <param name="enemy">L’ennemi concerné (non utilisé ici).</param>
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (player == null) return; // Sécurité

            // On choisit aléatoirement le montant de PV gagné.
            int healAmount = Random.Shared.Next(10, 30);

            // Le joueur se soigne.
            // Le message d'affichage est géré par la méthode Heal.
            player.Heal(healAmount);
        }
    }
}