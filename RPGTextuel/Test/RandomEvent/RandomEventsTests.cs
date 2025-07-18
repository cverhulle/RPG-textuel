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
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            RandomEventsTestsUtils.FindItemEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseItemEvent avec inventaire non vide 
        private static void TestLoseItemEventWithInventoryNotEmpty()
        {
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            RandomEventsTestsUtils.FindItemEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseItemEvent avec inventaire vide 
        private static void TestLoseItemEventWithInventoryEmpty()
        {
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            RandomEventsTestsUtils.LoseItemEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement GainHealthEvent avec la vie pleine 
        private static void TestGainHealthEventWithFullHealth()
        {
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            RandomEventsTestsUtils.GainHealthEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement GainHealthEvent avec la vie non pleine
        private static void TestGainHealthEventNotWithFullHealth()
        {
            Player player = PlayerTestFactory.CreateWoundedPlayer(20);

            RandomEventsTestsUtils.GainHealthEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseHealthEvent
        private static void TestLoseHealthEvent()
        {
        Player player = PlayerTestFactory.CreateBasicTestPlayer();

            RandomEventsTestsUtils.LoseHealthEventUtils(player);

            GameUtils.WaitForUser();
        }
    }
}
