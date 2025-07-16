using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;

namespace RPGTextuel.Test
{
    // Cette classe lance le test.
    public class TestLauncher
    {
        public static void Main()
        {
            TestSetupPlayerAndGoblinAndSmallHealAndDamagePotion();
        }

        // Cette méthode permet de tester la méthode SetupPlayerAndGoblinAndSmallHealAndDamagePotion.
        public static void TestSetupPlayerAndGoblinAndSmallHealAndDamagePotion()
        {
            (Player player, Enemy enemy) = TestUtils.SetupPlayerAndGoblinAndSmallHealAndDamagePotion();
            player.Inventory.DisplayInventory();
            enemy.PrintStats();
        }
    }
}