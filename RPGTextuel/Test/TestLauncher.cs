using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Extensions.Players;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.RandomEvents;

namespace RPGTextuel.Test
{
    // Cette classe lance le test.
    public static class TestLauncher
    {
        // On lance cette méthode pour tester le programme.
        public static void TestLauncherMain()
        {
        }

        // Cette méthode permet de tester la méthode SetupPlayerAndGoblinAndSmallHealAndDamagePotion.
        private static void TestSetupPlayerAndGoblinAndSmallHealAndDamagePotion()
        {
            (Player player, Enemy enemy) = TestUtils.SetupPlayerAndGoblinAndSmallHealAndDamagePotion();
            player.PrintStats();
            player.Inventory.DisplayInventory();
            enemy.PrintStats();
        }

        // Cette méthode permet de tester l'évenement FindItemEvent
        private static void TestFindtemEvent()
        {
            Player player = TestPlayerFactory.SetupPlayerAndSmallHealAndDamagePotion();

            Console.WriteLine("\n Événement : Trouver un objet");
            TestRandomEvents.TestFindItemEvent(player);

            GameUtils.WaitForUser();
        }
    }
}