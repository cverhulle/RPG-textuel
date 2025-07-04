using RPGTextuel.Core;

namespace RPGTextuel.Game.GameFeatures
{
    // Cette classe s'occupe de gérer l'affichage pour le jeu.
    public static class GameDisplay
    {

        // Cette méthode affiche le menu principal du jeu
        public static void ShowMainMenu(Player player)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("===== MENU PRINCIPAL =====");
                Console.WriteLine("1. Passer au combat suivant.");
                Console.WriteLine("2. Statistiques");
                Console.WriteLine("3. Voir l'inventaire.");
                Console.WriteLine("4. Quitter le jeu");
                Console.WriteLine("==========================");
                Console.Write("Choisissez une option : ");

                string? input = Console.ReadLine();
                Console.Clear();
            }
        }        

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
            Console.WriteLine("Bienvenue " + name);
            Console.WriteLine("Vous allez devoir affronter trois ennemis redoutables !");
            Console.WriteLine("Choisissez une option dans le menu suivant :");
            Console.WriteLine();
        }
    }
}