using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Augmentation de la chance de critique".
    public class GainCriticalChanceEvent : RandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Eclair de génie !";
        public override string Description => "Un éclair de lucidité traverse votre esprit. Vos prochaines attaques seront plus précises !";

        // On définit l'effet de l'événement.
        public override void Trigger(Player player)
        {
        }
    }
}