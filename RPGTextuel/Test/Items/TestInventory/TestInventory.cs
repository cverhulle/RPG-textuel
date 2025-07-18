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

            TestItems.TestAddSmallHealPotion();
        }

        // Cette méthode permet de tester la méthode DisplayInventory avec un inventaire vide.
        public static void TestDisplayInventoryWithEmptyInventory()
        {
            Console.WriteLine("=== Test de DisplayInventory avec un inventiare vide ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Console.WriteLine("\n Résultat attendu : Message d'erreur ; Inventaire vide : ");
            player.Inventory.DisplayInventory();
        }

        // Cette méthode permet de tester la méthode DisplayInventory avec un inventaire non vide.
        public static void TestDisplayInventoryWithNonEmptyInventory()
        {
            Console.WriteLine("=== Test de DisplayInventory avec un inventiare non vide ===");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();
            Console.WriteLine("\n Résultat attendu : Affichage fonctionnel ");
            player.Inventory.DisplayInventory();
        }

        // Cette méthode teste la fonction isEmpty avec inventaire vide
        public static void TestIsEmptyWithEmptyInventory()
        {
            Console.WriteLine("=== Test de isEmpty avec un inventaire vide ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Console.WriteLine($"Inventaire vide (attendu: true): {player.Inventory.IsEmpty()}");
        }

        // Cette méthode teste la fonction isEmpty avec inventaire non vide
        public static void TestIsEmptyWithInventoryNonEmpty()
        {
            Console.WriteLine("=== Test de isEmpty avec un inventaire non vide ===");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();
            Console.WriteLine($"Inventaire vide (attendu: false): {player.Inventory.IsEmpty()}");
        }

        // Cette méthode teste la fonction GetAllItems
        public static void TestGetAllItems()
        {
            Console.WriteLine("=== Test de GetAllItems ===");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            Console.WriteLine("\n Résultat attendu : Liste avec les 2 items du joueur (potion de soin et potion de dégats)");

            List<Item> items = player.Inventory.GetAllItems();
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"Item {i} : {items[i].name}");
            }
        }

        // Cette méthode permet de tester isValidItemIndex.
        public static void TestIsValidItemIndex()
        {
            Console.WriteLine("=== Test de IsValidItemIndex ===");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();
            Inventory inventory = player.Inventory;

            int itemCount = inventory.Count;

            Console.WriteLine($"Nombre d'items dans l'inventaire : {itemCount}");

            // Cas valides
            Console.WriteLine($"Index 0 valide ? (attendu : true) → {inventory.IsValidItemIndex(0)}");
            if (itemCount > 1)
                Console.WriteLine($"Index 1 valide ? (attendu : true) → {inventory.IsValidItemIndex(1)}");

            // Cas invalides
            Console.WriteLine($"Index -1 valide ? (attendu : false) → {inventory.IsValidItemIndex(-1)}");
            Console.WriteLine($"Index {itemCount} valide ? (attendu : false) → {inventory.IsValidItemIndex(itemCount)}");
        }

        // Test de la méthode GetItemNames.
        public static void TestGetItemNames()
        {
            Console.WriteLine("=== Test de GetItemNames ===");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();
            Inventory inventory = player.Inventory;

            List<string> itemNames = inventory.GetItemNames();

            Console.WriteLine("Résultat attendu : une liste contenant deux éléments : Une potion de soin et une de dégats (petite)");
            Console.WriteLine("Noms retournés :");
            foreach (string name in itemNames)
            {
                Console.WriteLine($"- {name}");
            }
        }

        // Cette méthode teste le retrait d'objet dans un inventaire non vide.
        public static void TestRemoveItemWithInventoryNotEmpty()
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
        */
    }
}