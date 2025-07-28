using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.InitGame;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de tester InitEnemiesToFight
    public static class TestInitEnemiesToFight
    {

        // Test de la méthode GetRandomGoblinSet 
        public static void TestGetRandomGoblinSet()
        {
            Console.WriteLine("=== Test de GetRandomGoblinSet (Affichage) ===");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\n--- Tirage {i} ---");
                List<Enemy> goblins = InitEnnemiesToFight.GetRandomGoblinSet();

                for (int j = 0; j < goblins.Count; j++)
                {
                    Enemy goblin = goblins[j];
                    Console.WriteLine($"Gobelin {j + 1} : Nom = {goblin.Name}, Type = {goblin.GetType().Name}");
                }
            }

            Console.WriteLine("\nTest terminé.");
        }
    }
}