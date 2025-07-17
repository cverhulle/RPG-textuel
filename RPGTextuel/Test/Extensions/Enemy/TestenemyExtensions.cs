using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.ExtensionsEnemy
{
    // Cette classe teste les méthodes du dossier Enemy dans Extensions
    public static class TestEnemyExtensions
    {
        // Cette méthode teste la méthode PrintStats
        public static void TestPrintStats()
        {
            Enemy enemy = TestEnememyFactory.TestGoblinMinionEnemyCreation();
            enemy.PrintStats();
        }
    }
}