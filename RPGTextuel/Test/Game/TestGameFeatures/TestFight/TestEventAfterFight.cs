using RPGTextuel.Core;
using RPGTextuel.Game.GameFeatures.Fight;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de tester EventAfterAFight
    public static class TestEventAfterAFight
    {
        // Cette méthode permet de tester EarnAnItem (hors combat de boss)
        public static void TestEarnAnItemByDefault()
        {
            Console.WriteLine("=== Test EarnAnItemByDefault ===");

            // On crée un joueur de test
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            Console.WriteLine("Inventaire avant l'ajout :");
            player.Inventory.DisplayInventory();

            // On appelle la méthode à tester
            EventAfterAFight.EarnAnItem(player, false);

            // On affiche l'inventaire après ajout
            Console.WriteLine("Inventaire après l'ajout :");
            player.Inventory.DisplayInventory();
        }

            // Cette méthode permet de tester EarnAnItem (combat de boss)
        public static void TestEarnAnItemAfterBoss()
        {
            Console.WriteLine("=== Test EarnAnItemByDefault ===");

            // On crée un joueur de test
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            Console.WriteLine("Inventaire avant l'ajout :");
            player.Inventory.DisplayInventory();

            // On appelle la méthode à tester
            EventAfterAFight.EarnAnItem(player, true);

            // On explicite le résultat attendu
            Console.WriteLine("Résultat attendu : Aucun changement");

            // On affiche l'inventaire après ajout
            Console.WriteLine("Inventaire après l'ajout :");
            player.Inventory.DisplayInventory();
        }
    }
}