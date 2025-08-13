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

            // On affiche le texte en bleu
            Console.ForegroundColor = ConsoleColor.Blue;

            // Intro de l'événement
            Console.WriteLine(introMessage);

            // Selection de l'événement aléatoire 
            var randomEvent = RandomEventFactory.GetRandomEvent();

            // Message d'informations pour l'utilisateur
            Console.WriteLine($"\nÉvénement : {randomEvent.Name}");
            Console.WriteLine($"{randomEvent.Description}\n");

            // Déclenchement de l'événement.
            randomEvent.Trigger(player);

            // On remet la couleur par défaut
            Console.ResetColor();
        }
    }
}