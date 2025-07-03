
namespace RPGTextuel.Game
{
    // Cette classe s'occupe de gérer la boucle de jeu.
    public static class GameLoop
    {

        // Cette méthode affiche le message de début de jeu
        private static void ShowWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Bienvenue dans AventureRPG ✨");
            Console.WriteLine("Vous allez affronter trois ennemis redoutables");
            Console.WriteLine("Avant cela, donnez un nom à votre héros");
        }

        // Cette méthode récupère le nom du héros du joueur
        private static void GetPlayerName()
        {

        }
    }
}