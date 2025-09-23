using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Utils;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    /// <summary>
    /// Événement aléatoire : le joueur gagne de la force grâce à un entraînement intensif.
    /// </summary>
    public class GainStrengthEvent : IRandomEvent
    {
        /// <summary>
        /// Événement aléatoire : le joueur gagne de la force grâce à un entraînement intensif.
        /// </summary>
        public string Name => "Entraînement intensif";

        /// <summary>
        /// Description de l'événement.
        /// </summary>
        public string Description => "Votre entraînement acharné vous rend plus fort !";

        /// <summary>
        /// Déclenche l'événement : le joueur gagne entre 1 et 3 points de force.
        /// </summary>
        /// <param name="player">Le joueur concerné par l'événement (peut être <c>null</c>).</param>
        /// <param name="enemy">L’ennemi concerné (non utilisé ici).</param>
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (player == null) return; // Sécurité


            // On applique la méthode générique
            player.Strength = (int)ModifyStatHelper.ModifyStatWithBounds(   
                stat: player.Strength,                                                      // Stat actuelle
                min: 1,                                                                     // Valeur minimale possible
                max: 999,                                                                   // Valeur max qu’on s’autorise
                randomMinChange: 1,                                                         // Gain minimal
                randomMaxChange: 3,                                                         // Gain maximal
                increase: true,                                                             // On augmente
                alreadyAtBoundMessage: "Votre force est déjà au maximum 💪",
                changeMessageTemplate: "Vous gagnez {0:0.#} point(s) de force !",           // Ici on n'est pas en %, donc {0:0.#} directement
                finalValueMessageTemplate: "Votre force est maintenant de {0:0.#}.",        // Pareil
                isPercentage : false,                                                       // La donnée n'est pas en pourcentage
                roundToInt: true                                                            // La force est un entier
            );
        }
    }
}