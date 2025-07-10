using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.Fight;
using RPGTextuel.Game.GameFeatures.InventoryNamespace;
using RPGTextuel.Game.GameFeatures.MainMenu;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.FightingAnEnemyMenus
{
    public class FightingAnEnemyMenu
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
            // On nettoie la console.
            Console.Clear();

            // On retourne le choix, valide, de l'utilisateur.
            return GameInputUser.AskMenuChoice(MainMenuChoice, "MENU PRINCIPAL");
        }

        // Cette méthode affiche le menu principal du jeu.
        // Elle récupère la réponse utilisateur et lance la méthode associée.
        public static void HandleMainMenu(Player player, Enemy enemy)
        {
            // On crée une variable pour gérer une boucle
            bool isRunning = true;

            // Tant qu'aucune réponse n'est fournie, on repète la question.
            while (isRunning)
            {
                // On affiche le menu principal.
                // On récupère la réponse, valide, de l'utilisateur.
                int input = AskMainMenuChoice();

                // On évalue la réponse de l'utilisateur et, on lance la méthode associée.
                switch (input)
                {
                    // On lance l'écran de combat
                    case 1:
                        MainFight.HandleBattle(player, enemy);
                        isRunning = false;
                        break;

                    // On affiche les statistiques du joueur.
                    case 2:
                        GameDisplay.PrintStats(player);
                        break;

                    // On affiche l'inventaire et on gère l'utilisation des objets sur soi-même
                    case 3:
                        // Les objets ne peuvent être utilisés que sur soi-même ici.
                        InventoryInteraction.PromptUseItem(player);
                        break;

                    // Fermeture du jeu
                    case 4:
                        isRunning = CloseGame.CloseTheGame();
                        break;

                    // Si la réponse n'est pas valide, on recommence la boucle.
                    default:
                        Console.WriteLine("Option invalide. Veuillez selectionner une option valide.");
                        break;
                }
            }
        }
    }
}