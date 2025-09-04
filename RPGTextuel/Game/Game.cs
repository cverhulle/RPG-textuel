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
                // On initialise la couleur par défaut
                Console.ForegroundColor = TextColorConfig.defaultColor;

                // On initialise la partie
                (Player player, List<Enemy> ennemies) = InitGame.InitTheGame();

                // On lance la boucle de jeu
                // On récupère l'état à la fin de la partie
                EndGameState endParty = MainMenu.HandleMainMenu(player, ennemies);

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
            }
        }
    }
}