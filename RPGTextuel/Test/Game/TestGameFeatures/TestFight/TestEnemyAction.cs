using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.Fight;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de teset EnemyAction
    public static class TestEnemyAction
    {
        // Cette méthode permet de tester EnemyTurn
        public static void TestEnemyTurn()
        {
            Console.WriteLine("=== Test EnemyTurn ===");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Enemy enemy = EnemyTestFactory.CreateGoblin();

            Console.WriteLine($"Vie du joueur avant l'attaque : {player.Health}");

            // On simule l'attaque de l'ennemi
            EnemyAction.EnemyTurn(player, enemy);
        }
    }
}