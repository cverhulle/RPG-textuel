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
            TestLosetemEventWithInventoryNotEmpty();
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

            TestRandomEvents.TestFindItemEvent(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseItemEvent avec inventaire non vide 
        private static void TestLosetemEventWithInventoryNotEmpty()
        {
            Player player = TestPlayerFactory.SetupPlayerAndSmallHealAndDamagePotion();

            TestRandomEvents.TestLoseItemEvent(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseItemEvent avec inventaire vide 
        private static void TestLosetemEventWithInventoryEmpty()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();

            TestRandomEvents.TestLoseItemEvent(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement GainHealthEvent avec la vie pleine 
        private static void TestGainHealthEventWithFullHealth()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();

            TestRandomEvents.TestGainHealthEvent(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement GainHealthEvent avec la vie non pleine
        private static void TestGainHealthEventNotWithFullHealth()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();
            player.TakeDamage(20);

            TestRandomEvents.TestGainHealthEvent(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseHealthEvent
        private static void TestLoseHealthEvent()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();

            TestRandomEvents.TestLoseHealthEvent(player);

            GameUtils.WaitForUser();
        }
    }
}