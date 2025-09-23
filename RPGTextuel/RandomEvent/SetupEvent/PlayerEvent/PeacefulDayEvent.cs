using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    /// <summary>
    /// Événement aléatoire : Ne fait rien
    /// </summary>
    public class PeacefulDayEvent : IRandomEvent
    {
        /// <summary>
        /// Nom de l'événement.
        /// </summary>
        public string Name => "Jour paisible";

        /// <summary>
        /// Description de l'événement.
        /// </summary>
        public string Description => "Le soleil est radieux, le vent est doux...";

        /// <summary>
        /// Déclenche l'événement : Ne fait rien, un simple texte est affiché
        /// </summary>
        /// <param name="player">Le joueur affecté par l'événement (non utilisé ici).</param>
        /// <param name="enemy">L’ennemi concerné (non utilisé ici).</param>
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (player == null) return; // Sécurité

            // Il ne se passe rien, juste un message d'information.
            Console.WriteLine("... Une journée paisible sans incident.");
        }
    }
}