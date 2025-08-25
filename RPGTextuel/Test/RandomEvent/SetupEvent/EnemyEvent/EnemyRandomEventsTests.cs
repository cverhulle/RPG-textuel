using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.RandomEvents
{
    // Cette classe regroupe les méthodes liées aux évenements aléatoires des ennemis.
    public static class EnemyRandomEventsTests
    {
        // Test de GainStrengthEnemyEvent par défaut
        public static void TestGainStrengthEnemyEventByDefault()
        {
            Console.WriteLine("===== Test de GainStrengthEnemyEventByDefault =====");

            Enemy enemy = EnemyTestFactory.CreateGoblin();

            Console.WriteLine("Résultat attendu : Augmentation aléatoire de la force (1 à 3).");
            EnemyRandomEventsTestsUtils.GainStrengthEnemyUtils(enemy);

            GameUtils.WaitForUser();
        }
    }
}