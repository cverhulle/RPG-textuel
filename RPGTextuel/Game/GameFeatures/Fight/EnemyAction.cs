using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.Fight
{
    // Cette méthode gère le tour d'action des ennemis.
    public static class EnemyAction
    {
        // Cette méthode gère le tour des ennemis.
        public static void EnemyTurn(Player player, Enemy enemy, bool isFinalBoss)
        {
            // Message d'action
            Console.WriteLine("\n== TOUR DE L'ADVERSAIRE ====");

            // Attaque de l'ennemi
            enemy.Attack(player);

            Console.WriteLine("============================");

            //Pause pour que le joueur ait le temps de lire
            GameUtils.WaitForUser();
        }
    }
}