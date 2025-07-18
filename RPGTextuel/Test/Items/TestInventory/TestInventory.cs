using RPGTextuel.Core;
using RPGTextuel.Extensions.Characters;
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

        // Test de la méthode UseItem avec succès.
        public static void TestUseItemSuccessfully()
        {
            Console.WriteLine("=== Test de UseItem avec succès ===");
            Player player = PlayerTestFactory.CreateWoundedPlayerWithPotions(50);
            int index = 0;

            Console.WriteLine("Vie avant :");
            player.PrintHealthBar();

            bool result = player.Inventory.UseItem(index, player, player);

            Console.WriteLine($"Résultat attendu : true → Résultat obtenu : {result}");
            Console.WriteLine("Vie après (attendu : PV en plus) :");
            player.PrintHealthBar();

            Console.WriteLine($"Nombre d'objets restant (attendu : 1) : {player.Inventory.Count}");
        }

        // Test de UseItem : Potion de dégats sur soi-même.
        public static void TestUseItemWithDamagePotionOnSelf()
        {
            Console.WriteLine("=== Test de UseItem échoué (potion de dégâts sur soi) ===");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            int index = 1; // index de la potion de dégats par défaut.
            bool result = player.Inventory.UseItem(index, player, player);

            Console.WriteLine($"Résultat attendu : false → Résultat obtenu : {result}");
            Console.WriteLine($"Nombre d'objets restant (attendu : 2) : {player.Inventory.Count}");
        }

        // Test de UseItem : Potion de soin avec vie pleine
        public static void TestUseItemWithHealPotionWhereAsPlayerAsFullHealth()
        {
            Console.WriteLine("=== Test de UseItem échoué (potion de soin avec vie pleine) ===");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            int index = 0; // index de la potion de dégats par défaut.
            bool result = player.Inventory.UseItem(index, player, player);

            Console.WriteLine($"Résultat attendu : false → Résultat obtenu : {result}");
            Console.WriteLine($"Nombre d'objets restant (attendu : 2) : {player.Inventory.Count}");
        }
        
        // Test de UseItem avec un index invalide.
        public static void TestUseItemWithInvalidIndex()
        {
            Console.WriteLine("=== Test de UseItem avec index invalide ===");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            int invalidIndex = 5;
            bool result = player.Inventory.UseItem(invalidIndex, player, player);

            Console.WriteLine($"Résultat attendu : false → Résultat obtenu : {result}");
            Console.WriteLine($"Nombre d'objets restant (attendu : 2) : {player.Inventory.Count}");
        }
    }
}