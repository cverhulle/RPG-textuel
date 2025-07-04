using RPGTextuel.Core;
using RPGTextuel.Game.GameFeatures;

namespace RPGTextuel.Game
{
    // Cette classe s'occupe de gérer la boucle de jeu.
    public static class Game
    {
        // Cette méthode a pour but de lancer la partie
        public static void StartGame()
        {
            // On initialise la partie
            Player joueur = InitGame();
        }

        // Cette méthode permet d'initialiser la partie.
        // Elle affiche les messages d'accueils, demande le nom du joueur et l'instancie.
        // Elle retourne le joueur ainsi crée de type Player.
        private static Player InitGame()
        {
            // On affiche le message d'accueil
            GameDisplay.ShowWelcomeMessage();

            // On récupère le nom du joueur
            string name = GamePlayerName.AskAndVerifyPlayerName();

            // On crée l'instance de type joueur
            Player joueur = CreatePlayer.CreateAPlayer(name);

            // On affiche le dexième message d'accueil
            GameDisplay.ShowWelcomeMessage2(name);

            return joueur;
        }

        // Cette méthode affiche le menu principal du jeu.
        // Elle récupère la réponse utilisateur et lance la méthode associée.
        public static void HandleMainMenu(Player player)
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
    }
}