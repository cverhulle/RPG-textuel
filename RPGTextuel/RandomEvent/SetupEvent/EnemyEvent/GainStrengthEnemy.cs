using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Utils;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    /// <summary>
    /// Événement aléatoire qui augmente la force du prochain ennemi.
    /// </summary>
    public class GainStrengthEnemyEvent : IRandomEvent
    {
        /// <summary>
        /// Nom de l'événement.
        /// </summary>
        public string Name => "Un adversaire impressionnant";

        
        /// <summary>
        /// Description de l'événement.
        /// </summary>
        public string Description => "D'après les rumeurs, le prochain adversaire est puissant...";

        /// <summary>
        /// Déclenche l'événement en augmentant la statistique de force du prochain ennemi.
        /// </summary>
        /// <param name="player">Le joueur concerné par l'événement (optionnel, peut être null).</param>
        /// <param name="enemy">L'ennemi dont la force sera modifiée.</param>
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (enemy == null) return; // Sécurité

            enemy.Strength = (int)ModifyStatHelper.ModifyStatWithBounds(
                stat: enemy.Strength,                                                                   // Stat à modifier
                min: 1,                                                                                 // Minimum 1 de force
                max: 999,                                                                               // Maximum 999 de force
                randomMinChange: 1,                                                                     // Au minimum on gagne 1
                randomMaxChange: 2,                                                                     // Au maximum, on gagne 2 de force
                increase: true,                                                                         // C'est une augmentation
                alreadyAtBoundMessage: "Le prochain adversaire est déjà au sommet de son art !",        // Message si l'ennemi est déjà à 999 de force.
                changeMessageTemplate: "La force du prochain adversaire a augmenté de {0:0.#} !",      // Message pour l'utilisateur
                finalValueMessageTemplate: "Force finale du prochain adversaire : {0:0.#}",            // Message pour l'utilisateur
                isPercentage: false,                                                                    // Les valeurs ne sont pas en pourcentage
                roundToInt: true                                                                        // La force est un entier
            );
        }
    }
}
