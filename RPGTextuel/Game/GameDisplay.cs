namespace RPGTextuel.Game
{
    // Cette classe s'occupe de gérer la boucle de jeu.
    public static class GameLoopDisplay
    {
        // Cette méthode affiche le message de début de jeu
        public static void ShowWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Bienvenue dans AventureRPG ✨");
            Console.WriteLine("Vous allez affronter trois ennemis redoutables !");
            Console.WriteLine("Avant cela, donnez un nom à votre héros 🐱‍🏍");
            Console.WriteLine();
        }
    }
}