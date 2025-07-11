using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Game.GameFeatures.EndGame;
using RPGTextuel.Game.GameFeatures.FightingAnEnemyMenus;
using RPGTextuel.Game.GameFeatures.InitGame;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game
{
    // Cette classe s'occupe de gérer la boucle de jeu.
    public static class Game
    {
        // Cette méthode a pour but de lancer la partie
        public static void StartGame()
        {
            // On initialise la partie
            (Player player, List<Enemy> ennemies) = InitGame.InitTheGame();

            // On lance la boucle de jeu
            // En cas d'arret de la partie, on récupère le booléan "true".
            Boolean stopGame = LaunchGame(player, ennemies);

            // Si tous les ennemis sont vaincus, on affiche le message de victoire.
            if (!stopGame)
            {
                EndGame.VictoryMessage();
            }
        }

        // Cette méthode lance la boucle de jeu.
        // Elle retourne, en booléan, l'arrêt de la partie.
        private static Boolean LaunchGame(Player player, List<Enemy> ennemies)
        {
            // Pour chaque ennemi dans la liste
            foreach (Enemy enemy in ennemies)
            {
                // On affiche un message indiquant qu'on passe au combat suivant.
                Console.Clear();
                Console.WriteLine($"Un nouvel ennemi approche !");
                enemy.PrintStats();
                GameUtils.WaitForUser();

                // On délègue la gestion du menu principal à une méthode dédiée
                Boolean wantsToQuit = FightingAnEnemyMenu.HandleMainMenu(player, enemy);

                // Si le joueur quite, on arrête la partie
                if (wantsToQuit)
                {
                    CloseGame.CloseTheGame();
                    return true;
                }

                // Si le joueur meurt, on arrête la partie
                if (!player.IsAlive)
                {
                    Console.WriteLine("Le joueur est mort. Fin de la partie.");
                    return true;
                }
            }
            return false;
        }
    }
}