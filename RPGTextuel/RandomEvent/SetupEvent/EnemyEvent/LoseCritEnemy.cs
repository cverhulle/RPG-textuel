using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Utils;

namespace RPGTextuel.RandomEvent.Events
{
    // On définit l'événement "Perte de chance de critique pour le prochain ennemi"
    public class LoseCritEnemyEvent : IRandomEvent
    {
        // On définit son nom et sa description.
        public string Name => "Un adversaire maladroit";
        public string Description => "Le prochain ennemi semble assez maladroit...";

        // On définit l'activation de l'événement.
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (enemy == null) return; // Sécurité

            enemy.CriticalHitChance = ModifyStatHelper.ModifyStatWithBounds(
                stat: enemy.CriticalHitChance,                                                                              // Stat à modifier
                min: 0.0,                                                                                                   // Minimum 0%
                max: 1.0,                                                                                                   // Maximum 100%
                randomMinChange: 0.05,                                                                                      // Réduction min : 5%
                randomMaxChange: 0.15,                                                                                      // Réduction max : 15%
                increase: false,                                                                                            // Diminution
                alreadyAtBoundMessage: "⚡ Le prochain adversaire n’a déjà aucune chance de coup critique !",
                changeMessageTemplate: "⚡ La probabilité de coup critique du prochain adversaire diminue de {0:0.#}%.",
                finalValueMessageTemplate: "⚡ Chance critique finale : {0:0.#}%.",
                isPercentage: true,                                                                                         // Les valeurs sont en pourcentage
                roundToInt: false                                                                                           // Le critique n'est pas un entier
            );
        }
    }
}