using RPGTextuel.Config;
using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.EndGameNamespace;
using RPGTextuel.Game.GameFeatures.InitGame;
using RPGTextuel.Game.GameFeatures.MainMenu;
using RPGTextuel.Game.GameUtilsNamespace;

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

            // On initialise l’identité du joueur.
            string playerName = InitGame.InitPlayerIdentityAndWelcomeMessage();

            // On compte le nombre de run
            int runCount = 0;

            // Tant que l'on rejoue, la partie continue
            while (replay)
            {
                // Affichage du message de lancement avant chaque run
                InitGame.InitMessageBeforeARun(playerName);

                // On joue une partie
                EndGameState endParty = PlayOneGame(playerName);

                // On gère le résultat de la partie.
                switch (endParty)
                {
                    case EndGameState.Victory:
                        EndGame.VictoryMessage();
                        replay = AskReplay();
                        break;

                    case EndGameState.PlayerDeath:
                        EndGame.DeathMessage();
                        replay = AskReplay();
                        break;

                    // Le joueur souhaite fermer le jeu : on sort de la boucle.
                    case EndGameState.PlayerQuit:
                        EndGame.PlayerCloseGame();
                        replay = false;
                        return;
                }

                runCount++;
            }
        }

        /// <summary>
        /// Joue une partie complète (init + combats).
        /// On retourne l’état final de la partie (victoire, défaite, quitter le jeu).
        /// </summary>
        private static EndGameState PlayOneGame(string playerName)
        {
            // On initialise la couleur par défaut
            Console.ForegroundColor = TextColorConfig.defaultColor;

            // On initialise la partie
            (Player player, List<Enemy> ennemies) = InitGame.InitNewRun(playerName);

            // On lance la boucle de jeu
            // On récupère l'état à la fin de la partie
            return MainMenu.HandleMainMenu(player, ennemies);
        }
        
        /// <summary>
        /// Demande au joueur s’il souhaite rejouer.
        /// </summary>
        private static bool AskReplay()
        {
            var options = new List<string> { "Oui", "Non" };

            int choice = GameInputUser.AskMenuChoice(
                options,
                title: "Voulez-vous rejouer ?",
                color: TextColorConfig.replayColor
            );

            return choice == 1;
        }
    }
}