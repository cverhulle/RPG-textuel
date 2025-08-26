using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.SetupEvent;

namespace RPGTextuel.Test.RandomEvents
{
    // Cette classe regroupe les méthodes d'aide liées aux évenements aléatoires des ennemis.
    public static class EnemyRandomEventsTestsUtils
    {
        // Méthode utilitaire liée à l'évenement GainStrengthEnemy avec les items par défaut.
        public static void GainStrengthEnemyUtils(Enemy enemy)
        {
            Console.WriteLine($"Force initiale : {enemy.Strength}");

            GainStrengthEnemyEvent evt = new GainStrengthEnemyEvent();
            evt.Trigger(enemy);
        }

        // Méthode utilitaire liée à l'évenement LoseStrengthEnemy avec les items par défaut.
        public static void LoseStrengthEnemyUtils(Enemy enemy)
        {
            Console.WriteLine($"Force initiale : {enemy.Strength}");

            LoseStrengthEnemyEvent evt = new LoseStrengthEnemyEvent();
            evt.Trigger(enemy);
        }
    }
}