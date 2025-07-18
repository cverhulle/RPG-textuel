using RPGTextuel.Core;
using RPGTextuel.Items.Class;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.Items
{
    // Cette classe teste les méthodes de la classe "Inventory"
    public static class TestInventory
    {
        // Cette méthode teste l'ajout d'objet dans l'inventaire du joueur.
        public static void TestAddItem()
        {
            Console.WriteLine("=== Test Ajout d'Item ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Inventory inventory = player.Inventory;

            Console.WriteLine("=== Test Ajout d'Item ===");
            Console.WriteLine($"Avant ajout (attendu : 0): {inventory.Count}");

            TestItems.TestAddSmallHealPotion();

            Console.WriteLine($"Après ajout (attendu: 1) : {inventory.Count}");
        }

        // Cette méthode teste le retrait d'objet dans un inventaire non vide.
        public static void TestRemoveItemWithInventoryNotempty()
        {
            Console.WriteLine("=== Test retrait d'item avec inventaire non vide ===");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();
            Inventory inventory = player.Inventory;

            Console.WriteLine("=== Etat initial ===");
            Console.WriteLine($"Nombre d'objets (attendu : 2): {inventory.Count}");

            player.Inventory.RemoveItemByIndex(0);

            Console.WriteLine($"Nombre d'objets (attendu: 1) : {inventory.Count}");
        }

        // Cette méthode teste le retrait d'objet dans l'inventaire.
        public static void TestRemoveItemWithEmptyInventory()
        {
            Console.WriteLine("=== Test retrait d'item avec inventaire vide ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Inventory inventory = player.Inventory;

            Console.WriteLine("=== Etat initial ===");
            Console.WriteLine($"Nombre d'objets (attendu : 0): {inventory.Count}");
            Console.WriteLine("\n Résultat attendu : Message d'erreur : ");
            player.Inventory.RemoveItemByIndex(0);
        }

        /*
        public static void TestUseItemValid()
        {
            Player player = new Player("Test");
            player.TakeDamage(30);
            Inventory inventory = player.Inventory;
            inventory.AddItem(new HealPotion(PotionSize.Small));

            bool result = inventory.UseItem(0, player, player);
            Console.WriteLine($"Item utilisé ? (attendu: true): {result}");
        }

        public static void TestUseItemInvalidIndex()
        {
            Player player = new Player("Test");
            bool result = player.Inventory.UseItem(99, player, player);
            Console.WriteLine($"Index invalide → item utilisé ? (attendu: false): {result}");
        }

        public static void TestIsEmpty()
        {
            Player player = new Player("Test");
            Console.WriteLine($"Inventaire vide (attendu: true): {player.Inventory.IsEmpty()}");
        }

        public static void TestGetItemNames()
        {
            Player player = new Player("Test");
            player.Inventory.AddItem(new HealPotion(PotionSize.Medium));
            var names = player.Inventory.GetItemNames();

            Console.WriteLine($"Nom du premier item (attendu: Potion de soin moyenne): {names[0]}");
        }
        */
    }
}