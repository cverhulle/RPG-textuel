using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Utils;
namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Gain de chance de critique pour le prochain ennemi"
    public class GainCritEnemyEvent : IRandomEvent
    {
        // On définit son nom et sa description.
        public string Name => "Un adversaire vicieux";
        public string Description => "Le prochain adversaire sait exploiter la moindre faille...";

        // On définit l'activation de l'événement.
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
                alreadyAtBoundMessage: "Le prochain adversaire est déjà expert en critique !",                              // Message si l'ennemi est déjà à 100% de crit.
                changeMessageTemplate: "La chance de coup critique du prochain adversaire a augmenté de {0:0.#}% !",        // Message pour l'utilisateur
                finalValueMessageTemplate: "Chance critique finale : {0:0.#}%",                                             // Message pour l'utilisateur
                isPercentage: true,                                                                                         // Les valeurs sont en pourcentage
                roundToInt: false                                                                                           // Le critique n'est pas un entier
            );
        }
    }
}