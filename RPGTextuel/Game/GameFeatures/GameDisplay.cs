using RPGTextuel.Core;

namespace RPGTextuel.Game.GameFeatures
{
    // Cette classe s'occupe de gérer l'affichage pour le jeu.
    public static class GameDisplay
    {

        // Cette méthode affiche le menu principal du jeu
        public static void ShowMainMenu(Player player)
        {
            // On crée une variable pour gérer une boucle
            bool isRunning = true;

            // Tant qu'aucune réponse n'est fournie, on repète la question.
            while (isRunning)
            {

                // On affiche le menu principal.
                Console.Clear();
                Console.WriteLine("===== MENU PRINCIPAL =====");
                Console.WriteLine("1. Passer au combat suivant.");
                Console.WriteLine("2. Statistiques");
                Console.WriteLine("3. Voir l'inventaire.");
                Console.WriteLine("4. Quitter le jeu");
                Console.WriteLine("==========================");
                Console.Write("Choisissez une option : ");

                // On récupère la réponse de l'utilisateur.
                string? input = Console.ReadLine();
                Console.Clear();

                // On évalue la réponse de l'utilisateur et, on lance la méthode associée.
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Combat suivant ");                        
                        break;

                    case "2":
                        Console.WriteLine("=== STATISTIQUES ===");
                        break;

                    case "3":
                        Console.WriteLine("=== INVENTAIRE ===");
                        break;

                    case "4":
                        Console.WriteLine("À bientôt !");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Option invalide. Appuyez sur une touche pour réessayer...");
                        break;
                }
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