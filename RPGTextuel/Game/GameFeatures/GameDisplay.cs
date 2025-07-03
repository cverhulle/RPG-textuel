namespace RPGTextuel.GameFeatures
{
    // Cette classe s'occupe de gérer l'affichage pour le jeu.
    public static class GameDisplay
    {
        // Cette méthode affiche le message de début de jeu
        public static void ShowWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Bienvenue dans AventureRPG ✨");
            Console.WriteLine("Vous allez affronter trois ennemis redoutables !");
            Console.WriteLine("Avant cela, donnez un nom à votre héros");
            Console.WriteLine();
        }
    }
}