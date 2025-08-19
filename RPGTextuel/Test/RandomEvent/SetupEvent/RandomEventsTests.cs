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
            Console.WriteLine("===== Test de FindItemEventByDefault ====="); 

            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            RandomEventsTestsUtils.FindItemEventUtilsByDefault(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement FindItemEvent avec le drop de boss.
        public static void TestFindItemEventWithBossItemDrop()
        {
            Console.WriteLine("===== Test de FindItemEventWithBossItemDrop ====="); 
            
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            RandomEventsTestsUtils.FindItemEventWithBossItemDrops(player);

            GameUtils.WaitForUser();
        }

        // Méthode de test de GainCriticalChancePlayerEvent
        public static void TestGainCriticalChancePlayerEventByDefault()
        {
            Console.WriteLine("===== Test de GainCriticalChancePlayerEventByDefault =====");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            Console.WriteLine("Résultat attendu : Le critique augmente d'une valeur aléatoire");
            RandomEventsTestsUtils.GainCriticalChancePlayerEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Méthode de test de GainCriticalChancePlayerEvent quand le critique est à 99%
        // On teste si l'ajout ne dépasse pas les 100%
        public static void TestGainCriticalChancePlayerEventWithAlmostFullCrit()
        {
            Console.WriteLine("===== Test de GainCriticalChancePlayerEventWithAlmostFullCrit =====");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            // On met le critique à 99%
            player.CriticalHitChance = 0.99;
            Console.WriteLine("Résultat attendu : Le critique augmente de 1% seulement");

            RandomEventsTestsUtils.GainCriticalChancePlayerEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Méthode de test de GainCriticalChancePlayerEvent quand le critique est à 100%
        public static void TestGainCriticalChancePlayerEventWithFullCrit()
        {
            Console.WriteLine("===== Test de GainCriticalChancePlayerEventWithFullCrit =====");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            // On met le critique à 100%
            player.CriticalHitChance = 1;
            Console.WriteLine("Résultat attendu : Message personnalisé indiquant que le critique ne peut pas être modifié");

            RandomEventsTestsUtils.GainCriticalChancePlayerEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement GainHealthEvent avec la vie non pleine
        public static void TestGainHealthEventNotWithFullHealth()
        {
            Console.WriteLine("===== Test de GainHealthEventNotWithFullHealth =====");

            Player player = PlayerTestFactory.CreateWoundedPlayer(20);

            RandomEventsTestsUtils.GainHealthEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement GainHealthEvent avec la vie pleine 
        public static void TestGainHealthEventWithFullHealth()
        {
            Console.WriteLine("===== Test de GainHealthEventWithFullHealth =====");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            RandomEventsTestsUtils.GainHealthEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Test de GainStrengthEvent par défaut
        public static void TestGainStrengthEventByDefault()
        {
            Console.WriteLine("===== Test de GainStrengthEventByDefault =====");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            Console.WriteLine("Résultat attendu : Augmentation aléatoire de la force (1 à 3).");
            RandomEventsTestsUtils.GainStrengthEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Test de GainStrengthEvent avec force proche du maximum
        public static void TestGainStrengthEventWithAlmostMaxStrength()
        {
            Console.WriteLine("===== Test de GainStrengthEventWithAlmostMaxStrength =====");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            player.Strength = 998;
            Console.WriteLine("Résultat attendu : Gain limité (1 point max).");
            RandomEventsTestsUtils.GainStrengthEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Méthode de test de LoseCriticalChancePlayerEventByDefault
        public static void TestLoseCriticalChancePlayerEventByDelfault()
        {
            Console.WriteLine("===== Test de LoseCriticalChancePlayerEventByDefault =====");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            Console.WriteLine("Résultat attendu : Diminution aléatoire du critique");
            RandomEventsTestsUtils.LoseCriticalChancePlayerEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Méthode de test de LoseCriticalChancePlayerEvent quand le critique est à 1%.
        // On teste que la baisse ne fait pas descendre sous les 0%
        public static void TestLoseCriticalChancePlayerEventWithAlmostNoCrit()
        {
            Console.WriteLine("===== Test de LoseCriticalChancePlayerEventWithAlmostNoCrit =====");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            // On met le critique à 1%.
            player.CriticalHitChance = 0.01;
            Console.WriteLine("Résultat attendu : Diminution du critique de 1% seulement.");

            RandomEventsTestsUtils.LoseCriticalChancePlayerEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Méthode de test de LoseCriticalChancePlayerEvent quand le critique est à 0%.
        public static void TestLoseCriticalChancePlayerEventWithNoCrit()
        {
            Console.WriteLine("===== Test de LoseCriticalChancePlayerEventWithNoCrit =====");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            // On met le critique à 0%.
            player.CriticalHitChance = 0;
            Console.WriteLine("Résultat attendu : Message personnalisé indiquant que le critique ne peut pas dimminuer.");

            RandomEventsTestsUtils.LoseCriticalChancePlayerEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseHealthEvent
        public static void TestLoseHealthEvent()
        {
            Console.WriteLine("===== Test de LoseHealthEvent =====");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            RandomEventsTestsUtils.LoseHealthEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseItemEvent avec inventaire vide 
        public static void TestLoseItemEventWithInventoryEmpty()
        {
            Console.WriteLine("===== Test de LoseItemEventWithInventoryEmpty =====");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            RandomEventsTestsUtils.LoseItemEventUtils(player);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester l'évenement LoseItemEvent avec inventaire non vide 
        public static void TestLoseItemEventWithInventoryNotEmpty()
        {
            Console.WriteLine("===== Test de LoseItemEventWithInventoryNotEmpty =====");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            RandomEventsTestsUtils.LoseHealthEventUtils(player);

            GameUtils.WaitForUser();
        }
        
        // Cette méthode permet de tester PeacefulDayEvent.
        public static void TestPeacefulDayEvent()
        {
            Console.WriteLine("===== Test de PeacefulDayEvent =====");

            Player player = PlayerTestFactory.CreateWoundedPlayerWithPotions(20);

            RandomEventsTestsUtils.PeacefulDayEventUtils(player);

            GameUtils.WaitForUser();
        }
    }
}