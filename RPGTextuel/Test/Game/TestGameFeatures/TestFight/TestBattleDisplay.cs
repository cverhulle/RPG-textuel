using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.Fight;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de teset BattleDisplay
    public static class TestBattleDisplay
    {
        // Cette méthode permet de tester ShowBattleState
        public static void TestShowBattleState()
        {
            Console.WriteLine("=== Test de ShowBattleState avec un joueur blessé et un ennemi full HP ===");

            Player player = PlayerTestFactory.CreateWoundedPlayer(20);
            Enemy enemy = EnemyTestFactory.CreateGoblinMinion();

            Console.WriteLine("Résultat attendu : affichage des barres de santé du joueur et de l'ennemi.");
            BattleDisplay.ShowBattleState(player, enemy);
        }
    }
}