using RPGTextuel.Core;
using RPGTextuel.Core.PlayerNamespace;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Gain de Force".
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
                stat: player.Strength,                                              // stat actuelle
                min: 1,                                                             // valeur minimale possible
                max: 999,                                                           // valeur max qu’on s’autorise
                randomMinChange: 1,                                                 // gain minimal (ici en "points bruts")
                randomMaxChange: 3,                                                 // gain maximal
                increase: true,                                                     // on augmente
                alreadyAtBoundMessage: "Votre force est déjà au maximum 💪",
                changeMessageTemplate: "Vous gagnez {0} points de force !",         // ici on n'est pas en %, donc {0} directement
                finalValueMessageTemplate: "Votre force est maintenant de {0}."     // pareil
            );
        }
    }
}