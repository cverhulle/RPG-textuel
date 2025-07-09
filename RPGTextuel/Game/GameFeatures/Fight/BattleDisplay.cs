using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Characters;

namespace RPGTextuel.Game.GameFeatures.Fight
{
    // Cette classe s'occupe de l'affichage dans les combats.
    public static class BattleDisplay
    {
        // Cette classe s'occupe d'afficher les infos sur les deux adversaires en combat.
        public static void ShowBattleState(Player player, Enemy enemy)
        {
            Console.Clear();
            Console.WriteLine("===== COMBAT EN COURS =====\n");

            // Affichage de la santé du joueur
            player.PrintHealthBar();

            Console.WriteLine("\n--- Ennemi ---");

            // Affichage de la santé de l'ennemi.
            enemy.PrintHealthBar();

            Console.WriteLine("\n============================\n");
        }
    }
}