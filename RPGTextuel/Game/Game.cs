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
                // En cas d'arret de la partie, on récupère le booléan "true".
                Boolean stopGame = MainMenu.HandleMainMenu(player, ennemies);

                // Si tous les ennemis sont vaincus, on affiche le message de victoire.
                if (!stopGame)
                {
                    EndGame.VictoryMessage();
                }
            }
        }
    }
}