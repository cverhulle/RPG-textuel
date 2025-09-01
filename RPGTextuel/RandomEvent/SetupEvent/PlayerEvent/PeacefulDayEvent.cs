using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Jour de paix" : il ne "fait rien"
    public class PeacefulDayEvent : IRandomEvent
    {
        // On définit le nom et la description de l'événement.
        public string Name => "Jour paisible";
        public string Description => "Le soleil est radieux, le vent est doux...";

        public void Trigger(Player? player, Enemy? enemy)
        {
            if (player == null) return; // Sécurité

            // Il ne se passe rien, juste un message d'information.
            Console.WriteLine("... Une journée paisible sans incident.");
        }
    }
}