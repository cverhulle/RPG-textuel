using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Extensions.Players;
using RPGTextuel.Test.ExtensionsEnemy;
using RPGTextuel.Test.ExtensionsList;

namespace RPGTextuel.Test
{
    // Cette classe lance le test.
    public static class TestLauncher
    {
        // On lance cette méthode pour tester le programme.
        public static void TestLauncherMain()
        {
            TestListExtensions.TestPickRandomWithNonEmptyList();
        }

        // Cette méthode permet de tester la méthode SetupPlayerAndGoblinAndSmallHealAndDamagePotion.
        private static void TestSetupPlayerAndGoblinAndSmallHealAndDamagePotion()
        {
            (Player player, Enemy enemy) = TestUtils.SetupPlayerAndGoblinAndSmallHealAndDamagePotion();
            player.PrintStats();
            player.Inventory.DisplayInventory();
            enemy.PrintStats();
        }
    }
}