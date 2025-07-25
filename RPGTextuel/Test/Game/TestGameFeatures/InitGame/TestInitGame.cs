using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.InitGame;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de tester InitGame
    public static class TestInitGame
    {

        // On lance la méthode InitTheGame pour la tester.
        // Ce n'est pas vraiment un test unitaire.
        public static void FakeTestInitTheGame()
        {
            (Player player, List<Enemy> ennemies) = InitGame.InitTheGame();

             Console.WriteLine("\n[TEST INIT GAME]");
            Console.WriteLine($"Nom du joueur : {player.Name}");
            Console.WriteLine($"PV du joueur : {player.Health}/{player.MaxHealth}");

            Console.WriteLine("\nListe des ennemis générés :");
            foreach (var enemy in ennemies)
            {
                Console.WriteLine($"- {enemy.Name} (Type : {enemy.GetType().Name}) - PV : {enemy.Health}/{enemy.MaxHealth}");
            }
        }
    }
}