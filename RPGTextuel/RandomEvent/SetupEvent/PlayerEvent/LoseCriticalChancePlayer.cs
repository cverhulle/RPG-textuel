using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Utils;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    /// <summary>
    /// Événement aléatoire : baisse de la chance de coup critique du joueur.
    /// </summary>
    public class LoseCriticalChancePlayerEvent : IRandomEvent
    {
        /// <summary>
        /// Nom de l'événement.
        /// </summary>
        public string Name => "Vision troublée";

        /// <summary>
        /// Description de l'événement.
        /// </summary>
        public string Description => "Une migraine soudaine trouble votre perception... Vos chances de viser juste diminuent.";

        /// <summary>
        /// Déclenche l'événement : diminue la chance de coup critique du joueur
        /// entre 3% et 10%.
        /// </summary>
        /// <param name="player">Le joueur concerné par l'événement (peut être <c>null</c>).</param>
        /// <param name="enemy">L’ennemi concerné (non utilisé ici).</param>
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (player == null) return; // Sécurité

            player.CriticalHitChance = ModifyStatHelper.ModifyStatWithBounds
                (
                    player.CriticalHitChance,                                   // Stat à modifier (chance de coup critique)
                    0.0, 1.0,                                                   // La chance de coup critique varie entre 0% et 100%
                    0.03, 0.10,                                                 // On diminue la chance de coup critique entre 3% et 10%
                    false,                                                      // On veut réaliser une diminution
                    "Votre précision est déjà au plus bas...",                  // Si la chance de coup critique est déjà à 0%; on personnalise le message
                    "Votre chance de coup critique a diminué de {0:0.#}% !",    // Affichage pour l'utilisateur
                    "Chance de critique actuelle : {0:0.#}%"                    // Affichage pour l'utilisateur
                );  
        }
    }
}