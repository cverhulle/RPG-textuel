using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Utils;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    /// <summary>
    /// Événement aléatoire qui réduit la force du prochain ennemi.
    /// </summary>
    public class LoseStrengthEnemyEvent : IRandomEvent
    {
        /// <summary>
        /// Nom de l'événement.
        /// </summary>
        public string Name => "Faiblesse détectée";

        
        /// <summary>
        /// Description de l'événement.
        /// </summary>
        public string Description => "Vous avez détécté une faiblesse sur prochain adversaire...";

        /// <summary>
        /// Déclenche l'événement en réduisant la force du prochain ennemi.
        /// </summary>
        /// <param name="player">Le joueur concerné par l'événement (optionnel, peut être null).</param>
        /// <param name="enemy">L'ennemi dont la statistique de force est modifiée.</param>
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (enemy == null) return; // Sécurité

            enemy.Strength = (int)ModifyStatHelper.ModifyStatWithBounds(
                stat: enemy.Strength,                                                                   // Stat à modifier
                min: 1,                                                                                 // Minimum 1 de force
                max: 999,                                                                               // Maximum 999 de force
                randomMinChange: 2,                                                                     // Au minimum on gagne 2
                randomMaxChange: 4,                                                                     // Au maximum, on gagne 4 de force
                increase: false,                                                                        // C'est une diminution
                alreadyAtBoundMessage: "Le prochain adversaire est déjà très faible !",                 // Message si l'ennemi est déjà à 1 de force.
                changeMessageTemplate: "La force du prochain adversaire a diminué de {0:0.#} !",        // Message pour l'utilisateur
                finalValueMessageTemplate: "Force finale du prochain adversaire : {0:0.#}",             // Message pour l'utilisateur
                isPercentage: false,                                                                    // Les valeurs ne sont pas en pourcentage
                roundToInt: true                                                                        // La force est un entier
            );
        }
    }
}