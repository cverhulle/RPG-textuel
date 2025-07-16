using RPGTextuel.Core;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.RandomEvents
{
    // Cette classe regroupe les tests liés aux évenements aléatoires
    public static class RandomEventsTests
    {
        // Cette méthode permet de tester l'évenement FindItemEvent
        private static void TestFindItemEvent()
        {
            Player player = TestPlayerFactory.SetupPlayerAndSmallHealAndDamagePotion();

            RandomEventsTestsUtils.FindItemEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseItemEvent avec inventaire non vide 
        private static void TestLoseItemEventWithInventoryNotEmpty()
        {
            Player player = TestPlayerFactory.SetupPlayerAndSmallHealAndDamagePotion();

            RandomEventsTestsUtils.FindItemEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseItemEvent avec inventaire vide 
        private static void TestLoseItemEventWithInventoryEmpty()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();

            RandomEventsTestsUtils.LoseItemEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement GainHealthEvent avec la vie pleine 
        private static void TestGainHealthEventWithFullHealth()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();

            RandomEventsTestsUtils.GainHealthEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement GainHealthEvent avec la vie non pleine
        private static void TestGainHealthEventNotWithFullHealth()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();
            player.TakeDamage(20);

            RandomEventsTestsUtils.GainHealthEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseHealthEvent
        private static void TestLoseHealthEvent()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();

            RandomEventsTestsUtils.LoseHealthEventUtils(player);

            GameUtils.WaitForUser();
        }
    }
}
