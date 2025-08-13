using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Factory;

namespace RPGTextuel.Game.GameFeatures.RandomEvents
{
    // Cette classe s'occupe de la gestion des évenements aléatoires.
    public static class RandomEventsInGame
    {
        // Cette méthode se déclenche lorsque l'utilisateur choisit l'option "Tenter un événement"
        // Cependant, il a déjà utilisé sa chance pour ce combat.
        public static void TriggerRandomEventButAlreadyTried()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vous avez déjà tenté votre chance pour cet affrontement !");
            Console.ResetColor();
        }

        // Cette méthode permet de déclencher un événement aléatoire.
        // Il est possible de personnalisé le message d'intro.
        public static void TriggerRandomEventWithIntro(Player player, string introMessage)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(introMessage);

            var randomEvent = RandomEventFactory.GetRandomEvent();
            Console.WriteLine($"\nÉvénement : {randomEvent.Name}");
            Console.WriteLine($"{randomEvent.Description}\n");
            Console.ResetColor();

            randomEvent.Trigger(player);
        }
    }
}