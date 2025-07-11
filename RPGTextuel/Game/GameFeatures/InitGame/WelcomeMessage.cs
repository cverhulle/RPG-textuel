using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.InitGame
{
    // Cette classe s'occupe de gérer l'affichage pour le jeu.
    public static class InitWelcomeMessage
    {
        // Cette méthode affiche le message de début de jeu
        public static void ShowWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Bienvenue dans AventureRPG ✨");
            Console.WriteLine("Avant de commencer, donnez un nom à votre héros !");
            Console.WriteLine();
        }

        // Cette méthode se déclenche après le choix du nom du personnage, après initialisation du jeu
        public static void ShowWelcomeMessage2(string name)
        {
            Console.WriteLine();
            Console.WriteLine("💥 Bienvenue " + name);
            Console.WriteLine("Vous allez devoir affronter trois ennemis redoutables !");
            GameUtils.WaitForUser();
        }
    }
}