using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Utils;
namespace RPGTextuel.RandomEvent.SetupEvent
{
    /// <summary>
    /// Événement aléatoire qui augmente la chance de coup critique du prochain ennemi.
    /// </summary>
    public class GainCritEnemyEvent : IRandomEvent
    {
        /// <summary>
        /// Nom de l'événement.
        /// </summary>
        public string Name => "Un adversaire vicieux";

        /// <summary>
        /// Description de l'événement.
        /// </summary>
        public string Description => "Le prochain adversaire sait exploiter la moindre faille...";

        /// <summary>
        /// Déclenche l'événement en augmentant la probabilité de coup critique de l'ennemi.
        /// </summary>
        /// <param name="player">Le joueur concerné par l'événement (optionnel, peut être null).</param>
        /// <param name="enemy">L'ennemi dont la chance de critique sera modifiée.</param>
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (enemy == null) return; // Sécurité

            enemy.CriticalHitChance = (int)ModifyStatHelper.ModifyStatWithBounds(
                stat: enemy.CriticalHitChance,                                                                              // Stat à modifier
                min: 0.0,                                                                                                   // Minimum 0% de crit
                max: 1.0,                                                                                                   // Maximum 100% de crit
                randomMinChange: 0.05,                                                                                      // Au minimum on gagne 5%
                randomMaxChange: 0.15,                                                                                      // Au maximum, on gagne 15%
                increase: true,                                                                                             // C'est une augmentation
                alreadyAtBoundMessage: "Le prochain adversaire est déjà expert en critique !",                              
                changeMessageTemplate: "La chance de coup critique du prochain adversaire a augmenté de {0:0.#}% !",        
                finalValueMessageTemplate: "Chance critique finale : {0:0.#}%",                                             
                isPercentage: true,                                                                                         // Les valeurs sont en pourcentage
                roundToInt: false                                                                                           // Le critique n'est pas un entier
            );
        }
    }
}