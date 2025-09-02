using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.RandomEvents
{
    // Cette classe regroupe les méthodes liées aux évenements aléatoires des ennemis.
    public static class EnemyRandomEventsTests
    {
        // Test de GainCritEnemyEvent par défaut
        public static void TestGainCritEnemyEventByDefault()
        {
            Console.WriteLine("===== Test de GainCritEnemyEventByDefault =====");

            Enemy enemy = EnemyTestFactory.CreateGoblin();

            Console.WriteLine("Résultat attendu : Augmentation aléatoire du critique de 5 à 15%.");
            EnemyRandomEventsTestsUtils.GainCritEnemyUtils(enemy);

            GameUtils.WaitForUser();
        }

        // Test de GainCritEnemyEvent avec critique proche du maximum.
        public static void TestGainCritEnemyEventWithAlmostMaxStrength()
        {
            Console.WriteLine("===== Test de GainCritEnemyEventWithAlmostMaxStrength =====");

            Enemy enemy = EnemyTestFactory.CreateGoblin();

            enemy.CriticalHitChance = 0.99;
            Console.WriteLine("Résultat attendu : Gain limité : 1%.");
            EnemyRandomEventsTestsUtils.GainCritEnemyUtils(enemy);

            GameUtils.WaitForUser();
        }

        // Test de GainCritEnemyEvent avec critique déjà au maximum.
        public static void TestGainCritEnemyEventWithMaxStrength()
        {
            Console.WriteLine("===== Test de GainCritEventWithMaxStrength =====");

            Enemy enemy = EnemyTestFactory.CreateGoblin();

            enemy.CriticalHitChance = 1;
            Console.WriteLine("Résultat attendu : Message indiquant que le critique est déjà au maximum.");
            EnemyRandomEventsTestsUtils.GainCritEnemyUtils(enemy);

            GameUtils.WaitForUser();
        }

        // Test de GainStrengthEnemyEvent par défaut
        public static void TestGainStrengthEnemyEventByDefault()
        {
            Console.WriteLine("===== Test de GainStrengthEnemyEventByDefault =====");

            Enemy enemy = EnemyTestFactory.CreateGoblin();

            Console.WriteLine("Résultat attendu : Augmentation aléatoire de la force (1 à 3).");
            EnemyRandomEventsTestsUtils.GainStrengthEnemyUtils(enemy);

            GameUtils.WaitForUser();
        }

        // Test de GainStrengthEnemyEvent avec force proche du maximum
        public static void TestGainStrengthEnemyEventWithAlmostMaxStrength()
        {
            Console.WriteLine("===== Test de GainStrengthEnemyEventWithAlmostMaxStrength =====");

            Enemy enemy = EnemyTestFactory.CreateGoblin();

            enemy.Strength = 998;
            Console.WriteLine("Résultat attendu : Gain limité (1 point max).");
            EnemyRandomEventsTestsUtils.GainStrengthEnemyUtils(enemy);

            GameUtils.WaitForUser();
        }

        // Test de GainStrengthEnemyEvent avec force déjà au maximum
        public static void TestGainStrengthEnemyEventWithMaxStrength()
        {
            Console.WriteLine("===== Test de GainStrengthEventWithMaxStrength =====");

            Enemy enemy = EnemyTestFactory.CreateGoblin();

            enemy.Strength = 999;
            Console.WriteLine("Résultat attendu : Message indiquant que la force est déjà au maximum.");
            EnemyRandomEventsTestsUtils.GainStrengthEnemyUtils(enemy);

            GameUtils.WaitForUser();
        }

        // Test de LoseStrengthEnemyEvent par défaut
        public static void TestLoseStrengthEnemyEventByDefault()
        {
            Console.WriteLine("===== Test de LoseStrengthEnemyEventByDefault =====");

            Enemy enemy = EnemyTestFactory.CreateGoblin();

            Console.WriteLine("Résultat attendu : Diminution aléatoire de la force (2 à 4).");
            EnemyRandomEventsTestsUtils.LoseStrengthEnemyUtils(enemy);

            GameUtils.WaitForUser();
        }

        // Test de LoseStrengthEnemyEvent avec force proche du minimum
        public static void TestLoseStrengthEnemyEventWithAlmostMinStrength()
        {
            Console.WriteLine("===== Test de LoseStrengthEnemyEventWithAlmostMaxStrength =====");

            Enemy enemy = EnemyTestFactory.CreateGoblin();

            enemy.Strength = 2;
            Console.WriteLine("Résultat attendu : Perte limité (1 point max).");
            EnemyRandomEventsTestsUtils.LoseStrengthEnemyUtils(enemy);

            GameUtils.WaitForUser();
        }

        // Test de LoseStrengthEnemyEvent avec force déjà au minimum
        public static void TestLoseStrengthEnemyEventWithMinStrength()
        {
            Console.WriteLine("===== Test de LoseStrengthEventWithMaxStrength =====");

            Enemy enemy = EnemyTestFactory.CreateGoblin();

            enemy.Strength = 1;
            Console.WriteLine("Résultat attendu : Message indiquant que la force est déjà au minimum.");
            EnemyRandomEventsTestsUtils.LoseStrengthEnemyUtils(enemy);

            GameUtils.WaitForUser();
        }
    }
}