using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Game.GameFeatures.FightingAnEnemyMenus;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.MainMenu
{
    // Cette classe s'occupe de gérer le menu principal.
    // Il apparaît entre chaque combat.
    public static class MainMenu
    {
        // Cette méthode lance la boucle de jeu.
        // Elle retourne, en booléan, l'arrêt, ou non, de la partie.
        public static Boolean HandleMainMenu(Player player, List<Enemy> ennemies)
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