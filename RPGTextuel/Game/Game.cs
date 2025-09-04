using RPGTextuel.Config;
using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.EndGameNamespace;
using RPGTextuel.Game.GameFeatures.InitGame;
using RPGTextuel.Game.GameFeatures.MainMenu;

namespace RPGTextuel.Game
{
    // Cette classe s'occupe de gérer la boucle de jeu.
    public static class Game
    {
        // Cette méthode a pour but de lancer la partie
        public static void StartGame()
        {
            // On regarde si le joueur souhaite rejouer.
            bool replay = true;

            // Tant que l'on rejoue, la partie continue
            while (replay)
            {
                EndGameState endParty = PlayOneGame();

                // On gère le résultat de la partie.
                switch (endParty)
                {
                    case EndGameState.Victory:
                        EndGame.VictoryMessage();
                        break;

                    case EndGameState.PlayerDeath:
                        // Le message de mort est déjà géré avant
                        break;

                    case EndGameState.PlayerQuit:
                        // Message déjà géré avant
                        // Le joueur a quitté : on sort directement de la boucle
                        return;
                }

                // Si le joueur n'a pas volontairement quitté, on propose de rejouer
                Console.WriteLine("\nVoulez-vous rejouer ? (o/n)");
                string? choix = Console.ReadLine()?.Trim().ToLower();
                replay = (choix == "o" || choix == "oui");
            }
        }

        /// <summary>
        /// Joue une partie complète (init + combats) et retourne l’état final.
        /// </summary>
        private static EndGameState PlayOneGame()
        {
            // On initialise la couleur par défaut
            Console.ForegroundColor = TextColorConfig.defaultColor;

            // On initialise la partie
            (Player player, List<Enemy> ennemies) = InitGame.InitTheGame();

            // On lance la boucle de jeu
            // On récupère l'état à la fin de la partie
            return MainMenu.HandleMainMenu(player, ennemies);
        }
        
        /// <summary>
        /// Demande au joueur s’il souhaite rejouer.
        /// </summary>
        private static bool AskReplay()
        {
            Console.WriteLine("\nVoulez-vous rejouer ? (o/n)");
            string? choix = Console.ReadLine()?.Trim().ToLower();
            return (choix == "o" || choix == "oui");
        }
    }
}