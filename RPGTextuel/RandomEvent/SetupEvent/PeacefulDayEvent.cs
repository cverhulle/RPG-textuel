using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Jour de paix" : il ne "fait rien"
    public class PeacefulDayEvent : RandomEventClass
    {
        // On définit le nom et la description de l'événement.
        public override string Name => "Jour paisible";
        public override string Description => "Le soleil est radieux, le vent est doux...";

        public override void Trigger(Player player)
        {
            // Il ne se passe rien, juste un message d'information.
            Console.WriteLine("... Une journée paisible sans incident.");
        }
    }
}