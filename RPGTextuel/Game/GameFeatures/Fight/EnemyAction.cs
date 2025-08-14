using RPGTextuel.Config;
using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.Fight
{
    // Cette méthode gère le tour d'action des ennemis.
    public static class EnemyAction
    {
        // Cette méthode gère le tour des ennemis.
        public static void EnemyTurn(Player player, Enemy enemy, Boolean isFinalBoss)
        {
            // On calcule la couleur de l'affichage
            ConsoleColor colorToDisplay = isFinalBoss ? GameConfig.bossColor : GameConfig.ennemiesColor;

            // Message d'action
            Console.WriteLine("\n== TOUR DE L'ADVERSAIRE ====");

            // Attaque de l'ennemi
            enemy.Attack(player);

            Console.WriteLine("============================");

            // On reset la couleur de l'écran
            Console.ResetColor();            

            //Pause pour que le joueur ait le temps de lire
            GameUtils.WaitForUser(color : colorToDisplay);
        }
    }
}