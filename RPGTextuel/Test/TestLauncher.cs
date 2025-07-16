using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Extensions.Players;

namespace RPGTextuel.Test
{
    // Cette classe lance le test.
    public class TestLauncher
    {
        // On lance cette méthode pour tester le programme.
        public static void TestLauncherMain()
        {
            (Player player, Enemy enemy) = TestUtils.SetupPlayerAndGoblinAndSmallHealAndDamagePotion();
            player.TakeDamage(20);
        }

        // Cette méthode permet de tester la méthode SetupPlayerAndGoblinAndSmallHealAndDamagePotion.
        private void TestSetupPlayerAndGoblinAndSmallHealAndDamagePotion()
        {
            (Player player, Enemy enemy) = TestUtils.SetupPlayerAndGoblinAndSmallHealAndDamagePotion();
            player.PrintStats();
            player.Inventory.DisplayInventory();
            enemy.PrintStats();
        }

        // Cette méthode permet de tester les 4 évenements aléatoires
        private void TestAllEvents()
        {
            
        }
    }
}