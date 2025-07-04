using RPGTextuel.Core;

namespace RPGTextuel.Game.GameFeatures
{
    public class GameMainMenu
    {
        // Cette variable contient les options du menu principal.
        public static readonly List<string> MainMenuChoice = new List<string>
        {
            "Passer au combat suivant.",
            "Statistiques",
            "Voir l'inventaire.",
            "Quitter le jeu"
        };

        // Cette méthode affiche le menu principal.
        // Elle retourne le choix, valide, de l'utilisateur
        public static int AskMainMenuChoice()
        {
            // On déclare la variable input.
            int input;

            // On nettoie la console.
            Console.Clear();

            // On retourne le choix, valide, de l'utilisateur.
            return input = GameInputUser.AskMenuChoice(MainMenuChoice, "MENU PRINCIPAL");
        }



        // --------------------- TODO : A SIMPLIFIER ------------------------------

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
                // On récupère la réponse, valide, de l'utilisateur.
                int input = AskMainMenuChoice();
/*
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
*/
            }
        }
    }
}