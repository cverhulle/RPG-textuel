using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.SetupEvent;

namespace RPGTextuel.Test.RandomEvents
{
    // Cette classe regroupe les méthodes d'aide liées aux évenements aléatoires des ennemis.
    public static class EnemyRandomEventsTestsUtils
    {
        // Méthode utilitaire liée à l'évenement GainCritEnemy.
        public static void GainCritEnemyUtils(Enemy enemy)
        {
            Console.WriteLine($"Critique initial : {enemy.CriticalHitChance}");

            GainCritEnemyEvent evt = new GainCritEnemyEvent();
            evt.Trigger(null, enemy);
        }

        // Méthode utilitaire liée à l'évenement GainStrengthEnemy.
        public static void GainStrengthEnemyUtils(Enemy enemy)
        {
            Console.WriteLine($"Force initiale : {enemy.Strength}");

            GainStrengthEnemyEvent evt = new GainStrengthEnemyEvent();
            evt.Trigger(null, enemy);
        }

        // Méthode utilitaire liée à l'évenement LoseStrengthEnemy.
        public static void LoseStrengthEnemyUtils(Enemy enemy)
        {
            Console.WriteLine($"Force initiale : {enemy.Strength}");

            LoseStrengthEnemyEvent evt = new LoseStrengthEnemyEvent();
            evt.Trigger(null, enemy);
        }
    }
}