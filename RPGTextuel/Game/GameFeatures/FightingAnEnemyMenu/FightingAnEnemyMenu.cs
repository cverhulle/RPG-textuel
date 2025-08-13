using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.Fight;
using RPGTextuel.Game.GameFeatures.InventoryNamespace;
using RPGTextuel.Game.GameFeatures.RandomEvents;
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
            "Tenter un événement aléatoire",
            "Quitter le jeu"
        };

        // Cette méthode affiche le menu principal.
        // Elle retourne le choix, valide, de l'utilisateur
        private static int AskMainMenuChoice()
        {
            // On nettoie la console.
            Console.Clear();

            // On retourne le choix, valide, de l'utilisateur.
            return GameInputUser.AskMenuChoice(MainMenuChoice, "MENU PRINCIPAL");
        }

        // Cette méthode permet de gérer le cas où l'utilisateur choisit l'événement aléatoire.
        // Disponible une seule fois entre chaque combat.
        private static void HandleRandomEvent(Player player, ref bool alreadyTried)
        {
            if (alreadyTried)
            {
                RandomEventsInGame.TriggerRandomEventButAlreadyTried();
            }
            else
            {
                RandomEventsInGame.TriggerRandomEventWithIntro(
                    player,
                    "Vous tentez votre chance avec un événement aléatoire...");
                    alreadyTried = true;
            }

            GameUtils.WaitForUser(color: ConsoleColor.Blue);
        }

        // Cette méthode affiche le menu de combat contre un ennemi donné
        // Elle retourne un booléan déterminant si l'utilisateur veut continuer de jouer ou non.
        public static Boolean HandleMainMenu(Player player, Enemy enemy)
        {
            // Cette variable permet de controler si l'utilisateur a déjà tenté l'événement aléatoire ou non.
            bool randomEventAlreadyTried = false;

            // On crée une boucle infinie. Tant que le combat n'est pas choisi
            // Ou que le joueur ne quitte pas le jeu, on continue !
            while (true)
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
                        return false;

                    // On affiche les statistiques du joueur.
                    case 2:
                        GameDisplay.PrintStats(player);
                        break;

                    // On affiche l'inventaire et on gère l'utilisation des objets sur soi-même
                    case 3:
                        // Les objets ne peuvent être utilisés que sur soi-même ici.
                        InventoryInteraction.PromptUseItem(player);
                        break;

                    // On gère le cas de l'événement aléatoire
                    case 4:
                        HandleRandomEvent(player, ref randomEventAlreadyTried);
                        break;

                    // Fermeture du jeu
                    case 5:
                        return true;

                    // Si la réponse n'est pas valide, on recommence la boucle.
                    default:
                        Console.WriteLine("Option invalide. Veuillez selectionner une option valide.");
                        break;
                }
            }
        }
    }
}