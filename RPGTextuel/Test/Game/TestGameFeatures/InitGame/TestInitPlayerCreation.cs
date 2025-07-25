using RPGTextuel.Core;
using RPGTextuel.Game.GameFeatures.InitGame;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de tester InitPlayerCreation
    public static class TestInitPlayerCreation
    {

        // Test de la méthode CreateAPlayer
        public static void TestCreateAPlayer()
        {   
            Console.WriteLine("=== Test de CreateAPlayer ===");

            string playerName = "Testeur";
            Player player = InitPlayerCreation.CreateAPlayer(playerName);

            Console.WriteLine("Résultat attendu : joueur nommé 'Testeur' avec 2 potions de soin (small, medium) et 2 de dégâts (small, medium).");
            Console.WriteLine("Résultat obtenu :");
            Console.WriteLine($"Nom du joueur : {player.Name}");
            Console.WriteLine("Inventaire :");

            foreach (var item in player.Inventory.GetAllItems())
            {
                Console.WriteLine($"- {item.name}");
            }
        }
    }
}