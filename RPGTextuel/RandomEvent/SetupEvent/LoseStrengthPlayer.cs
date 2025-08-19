using RPGTextuel.Core;
using RPGTextuel.Core.PlayerNamespace;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Perte de Force pour le joueur".
    public class LoseStrengthEvent : RandomEventClass
    {
        public override string Name => "Blessure musculaire";
        public override string Description => "Une mauvaise blessure vous affaiblit...";

        public override void Trigger(Player player)
        {
            player.Strength = (int)PlayerStatHelper.ModifyStatWithBounds(
                stat: player.Strength,                                              // Stat à modifier
                min: 1,                                                             // Valeur minimale possible
                max: 999,                                                           // Valeur max qu’on s’autorise
                randomMinChange: 1,                                                 // Perte minimale
                randomMaxChange: 2,                                                 // Perte maximale
                increase: false,                                                    // On perd des points
                alreadyAtBoundMessage: "Vous êtes déjà au minimum de force.",
                changeMessageTemplate: "Vous perdez {0} points de force...",        // Ici on n'est pas en %, donc {0} directement
                finalValueMessageTemplate: "Votre force est maintenant de {0}."     // Pateil
            );
        }
    }
}