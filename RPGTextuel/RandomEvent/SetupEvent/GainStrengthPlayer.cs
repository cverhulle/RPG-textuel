using RPGTextuel.Core;
using RPGTextuel.Core.PlayerNamespace;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Gain de Force pour le joueur".
    public class GainStrengthEvent : RandomEventClass
    {
        // Nom et description de l'événement
        public override string Name => "Entraînement intensif";
        public override string Description => "Votre entraînement acharné vous rend plus fort !";

        // Activation de l'événement :
        // Gain aléatoire entre 1 et 3 points de Force
        public override void Trigger(Player player)
        {
            // On applique la méthode générique
            player.Strength = (int)PlayerStatHelper.ModifyStatWithBounds(   
                stat: player.Strength,                                                      // Stat actuelle
                min: 1,                                                                     // Valeur minimale possible
                max: 999,                                                                   // Valeur max qu’on s’autorise
                randomMinChange: 1,                                                         // Gain minimal
                randomMaxChange: 3,                                                         // Gain maximal
                increase: true,                                                             // On augmente
                alreadyAtBoundMessage: "Votre force est déjà au maximum 💪",
                changeMessageTemplate: "Vous gagnez {0:0.#} points de force !",             // Ici on n'est pas en %, donc {0:0.#} directement
                finalValueMessageTemplate: "Votre force est maintenant de {0:0.#}.",        // Pareil
                isPercentage : false,                                                       // La donnée n'est pas en pourcentage
                roundToInt: true                                                            // La force est un entier
            );
        }
    }
}