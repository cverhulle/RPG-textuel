using RPGTextuel.Core;
using RPGTextuel.Core.PlayerNamespace;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Augmentation de la chance de critique".
    public class GainCriticalChancePlayerEvent : RandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Eclair de génie !";
        public override string Description => "Un éclair de lucidité traverse votre esprit. Vos prochaines attaques seront plus précises !";

        // On définit l'effet de l'événement : Augmentation de la chance de coup critique.
        public override void Trigger(Player player)
        {
            player.CriticalHitChance = PlayerStatHelper.ModifyStatWithBounds
                (
                    player.CriticalHitChance,
                    0.0, 1.0,
                    0.05, 0.15,
                    true,
                    "Votre précision est déjà parfaite ! Aucun gain possible.",
                    "Votre chance de coup critique a augmenté de {0:0.#}% !",
                    "Chance de critique actuelle : {0:0.#}%"
                );
        }
    }
}