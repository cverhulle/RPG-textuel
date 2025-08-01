using RPGTextuel.Core;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.RandomEvents
{
    // Cette classe regroupe les tests liés aux évenements aléatoires
    public static class RandomEventsTests
    {
        // Cette méthode permet de tester l'évenement FindItemEvent par défaut.
        public static void TestFindItemEventByDefault()
        {
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            RandomEventsTestsUtils.FindItemEventUtilsByDefault(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseItemEvent avec inventaire non vide 
        public static void TestLoseItemEventWithInventoryNotEmpty()
        {
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            RandomEventsTestsUtils.LoseHealthEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseItemEvent avec inventaire vide 
        public static void TestLoseItemEventWithInventoryEmpty()
        {
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            RandomEventsTestsUtils.LoseItemEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement GainHealthEvent avec la vie pleine 
        public static void TestGainHealthEventWithFullHealth()
        {
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            RandomEventsTestsUtils.GainHealthEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement GainHealthEvent avec la vie non pleine
        public static void TestGainHealthEventNotWithFullHealth()
        {
            Player player = PlayerTestFactory.CreateWoundedPlayer(20);

            RandomEventsTestsUtils.GainHealthEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseHealthEvent
        public static void TestLoseHealthEvent()
        {
        Player player = PlayerTestFactory.CreateBasicTestPlayer();

            RandomEventsTestsUtils.LoseHealthEventUtils(player);

            GameUtils.WaitForUser();
        }
    }
}