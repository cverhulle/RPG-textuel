using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Utils;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    /// <summary>
    /// Événement aléatoire : le joueur perd de la force à cause d’une blessure.
    /// </summary>
    public class LoseStrengthEvent : IRandomEvent
    {
        /// <summary>
        /// Nom de l'événement.
        /// </summary>
        public string Name => "Blessure musculaire";

        /// <summary>
        /// Description de l'événement.
        /// </summary>
        public string Description => "Une mauvaise blessure vous affaiblit...";

        /// <summary>
        /// Déclenche l'événement : réduit la force du joueur d’un montant aléatoire compris entre 1 et 2.
        /// La valeur est bornée pour rester dans les limites autorisées (1 à 999).
        /// </summary>
        /// <param name="player">Le joueur affecté par l'événement (peut être <c>null</c>).</param>
        /// <param name="enemy">L’ennemi concerné (non utilisé ici).</param>
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (player == null) return; // Sécurité

            player.Strength = (int)ModifyStatHelper.ModifyStatWithBounds(
                stat: player.Strength,                                              // Stat à modifier
                min: 1,                                                             // Valeur minimale possible
                max: 999,                                                           // Valeur max qu’on s’autorise
                randomMinChange: 1,                                                 // Perte minimale
                randomMaxChange: 2,                                                 // Perte maximale
                increase: false,                                                    // On perd des points
                alreadyAtBoundMessage: "Vous êtes déjà au minimum de force.",
                changeMessageTemplate: "Vous perdez {0} points de force...",        // Ici on n'est pas en %, donc {0} directement
                finalValueMessageTemplate: "Votre force est maintenant de {0}." ,    // Pareil
                isPercentage : false,                                               // La donnée n'est pas en pourcentage
                roundToInt: true                                                     // La force est un entier
            );
        }
    }
}