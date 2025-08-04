using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Factory;

namespace RPGTextuel.Game.GameFeatures.FightingAnEnemyMenus
{
    // Cette classe regroupe les méthodes utilitaires liées à FightingAnEnemyMenu
    public class FightingAnEnemyMenuUtils
    {
        // Cette méthode se déclenche lorsque l'utilisateur choisit l'option "Tenter un événement"
        // Cependant, il a déjà utilisé sa chance pour ce combat.
        public static void ChooseRandomEventButAlreadyTried()
        {
            Console.WriteLine("Vous avez déjà tenté votre chance pour cet affrontement !");
        }

        // Cette méthode se déclenche lorsque l'utilisateur choisit l'option "Tenter un événement"
        public static void ChooseRandomEvent(Player player)
        {
            Console.Clear();
            Console.WriteLine("Vous tentez votre chance avec un événement aléatoire...");
            var randomEvent = RandomEventFactory.GetRandomEvent();
            Console.WriteLine($"\nÉvénement : {randomEvent.Name}");
            Console.WriteLine($"{randomEvent.Description}\n");
            randomEvent.Trigger(player);
        }
    }
}