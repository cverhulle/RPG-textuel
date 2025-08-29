using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class;
using RPGTextuel.Utils;
namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Gain de force pour le prochain ennemi
    public class LoseStrengthEnemyEvent : EnemyRandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Faiblesse détectée";
        public override string Description => "D'après les rumeurs, le prochain adversaire n'est pas si puissant...";

        // On définit l'activation de l'événement.
        public override void Trigger(Enemy enemy)
        {
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