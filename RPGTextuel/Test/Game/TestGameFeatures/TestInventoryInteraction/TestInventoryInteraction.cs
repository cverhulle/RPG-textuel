using RPGTextuel.Core;
using RPGTextuel.Game.GameFeatures.InventoryNamespace;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.Game.TestGameUtils
{
    // Cette classe permet de tester InventoryInteraction
    public static class TestInventoryInteraction
    {
        // Cette méthode permet de tester GetItemNameListsAndBackMessage
        public static void TestGetItemNameListsAndBackMessage()
        {
            Console.WriteLine("=== Test de GetItemNameListsAndBackMessage ===");

            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            var result = InventoryInteraction.GetItemNameListsAndBackMessage(player.Inventory.GetAllItems(), "Quitter");

            Console.WriteLine("Résultat attendu : [\"Petite potion de soin\", \"Potion de dégât moyenne\", \"Quitter\"]");
            Console.WriteLine("Résultat obtenu :");
            foreach (var name in result)
            {
                Console.WriteLine($"- {name}");
            }
        }
    }
}