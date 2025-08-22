using RPGTextuel.Core.PlayerNamespace;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Gain de force pour le prochain ennemi
    public class GainStrengthEnemyEvent : EnemyRandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Un adversaire impressionnant";
        public override string Description => "D'après les rumeurs, le prochain adversaire est puissant...";

        // On définit l'activation de l'événement.
        public override void Trigger(Enemy enemy)
        {
            enemy.Strength = (int)PlayerStatHelper.ModifyStatWithBounds(
                stat: enemy.Strength,                                                                   // Stat à modifier
                min: 1,                                                                                 // Minimum 1 de force
                max: 999,                                                                               // Maximum 999 de force
                randomMinChange: 1,                                                                     // Au minimum on gagne 1
                randomMaxChange: 2,                                                                     // Au maximum, on gagne 2 de force
                increase: true,                                                                         // C'est une augmentation
                alreadyAtBoundMessage: "Le prochain adversaire est déjà au sommet de son art !",        // Message si l'ennemi est déjà à 999 de force.
                changeMessageTemplate: "La force du prochain adversaire a augmenté de {0:0.#}% !",      // Message pour l'utilisateur
                finalValueMessageTemplate: "Force finale du prochain adversaire : {0:0.#}%",            // Message pour l'utilisateur
                isPercentage: false,                                                                    // Les valeurs ne sont pas en pourcentage
                roundToInt: true                                                                        // La force est un entier
            );
        }
    }
}
