using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.ExtensionsEnemy
{
    // Cette classe teste les méthodes du dossier Enemy dans Extensions
    public static class TestEnemyExtensions
    {
        // On teste la méthode PrintStats pour un petit gobelin.
        public static void TestGoblinMinionStats()
        {
            Console.WriteLine("=== Test : PrintStats (Goblin Minion) ===");
            Enemy enemy = EnemyTestFactory.CreateGoblinMinion();
            enemy.PrintStats();
            GameUtils.WaitForUser();
        }

        // On teste la méthode PrintStats pour un gobelin.
        public static void TestGoblinStats()
        {
            Console.WriteLine("=== Test : PrintStats (Goblin) ===");
            Enemy enemy = EnemyTestFactory.CreateGoblin();
            enemy.PrintStats();
            GameUtils.WaitForUser();
        }

        // On teste la méthode PrintStats pour un chef gobelin.
        public static void TestGoblinChiefStats()
        {
            Console.WriteLine("=== Test : PrintStats (Goblin Chief) ===");
            Enemy enemy = EnemyTestFactory.CreateGoblinChief();
            enemy.PrintStats();
            GameUtils.WaitForUser();
        }
    }
}