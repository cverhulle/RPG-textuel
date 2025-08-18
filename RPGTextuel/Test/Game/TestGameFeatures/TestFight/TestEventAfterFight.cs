using RPGTextuel.Core;
using RPGTextuel.Game.GameFeatures.Fight;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de tester EventAfterAFight
    public static class TestEventAfterAFight
    {
        // Cette méthode permet de tester EarnAnItem
        public static void TestEarnAnItem()
        {
            Console.WriteLine("=== Test EarnAnItem ===");

            // On crée un joueur de test
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            Console.WriteLine("Inventaire avant l'ajout :");
            player.Inventory.DisplayInventory();

            // On appelle la méthode à tester
            EventAfterAFight.EarnAnItem(player);

            // On affiche l'inventaire après ajout
            Console.WriteLine("Inventaire après l'ajout :");
            player.Inventory.DisplayInventory();
        }
    }
}