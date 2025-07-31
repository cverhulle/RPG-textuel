using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Pas d'événement"
    public class NoEvent : RandomEventClass
    {
        // On définit le nom et la description de l'événement.
        public override string Name => "Aucun événement";
        public override string Description => "Il ne se passe rien aujourd'hui.";

        public override void Trigger(Player player)
        {
            // Il ne se passe rien, juste un message d'information.
            Console.WriteLine("... Une journée paisible sans incident.");
        }
    }
}