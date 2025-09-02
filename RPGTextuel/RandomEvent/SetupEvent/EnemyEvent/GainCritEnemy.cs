using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Utils;
namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Gain de chance de critique pour le prochain ennemi
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
                stat: enemy.CriticalHitChance,                                                                   // Stat à modifier
                min: 0.0,                                                                                 // Minimum 1 de force
                max: 1.0,                                                                               // Maximum 999 de force
                randomMinChange: 0.05,                                                                     // Au minimum on gagne 1
                randomMaxChange: 0.15,                                                                     // Au maximum, on gagne 2 de force
                increase: true,                                                                         // C'est une augmentation
                alreadyAtBoundMessage: "Le prochain adversaire est déjà expert en critique !",        // Message si l'ennemi est déjà à 999 de force.
                changeMessageTemplate: "La chance de coup critique du prochain adversaire a augmenté de {0:0.#}% !",      // Message pour l'utilisateur
                finalValueMessageTemplate: "Chance critique finale : {0:0.#}%",            // Message pour l'utilisateur
                isPercentage: true,                                                                    // Les valeurs ne sont pas en pourcentage
                roundToInt: false                                                                        // La force est un entier
            );
        }
    }
}