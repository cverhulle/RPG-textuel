using RPGTextuel.Core;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.Items
{
    // Cette classe contient les tests pour vérifier le bon fonctionnement des objets.
    public static class TestItems
    {
        // Vérifie qu'une petite potion de soin est bien ajoutée à l'inventaire.
        public static void TestAddSmallHealPotion()
        {
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            Console.WriteLine("Inventaire avant ajout de la potion de soin :");
            player.Inventory.DisplayInventory();

            player.AddSmallHealPotionToInventory();

            Console.WriteLine("Inventaire après ajout de la potion de soin :");
            player.Inventory.DisplayInventory();
        }

        // Vérifie qu'une petite potion de dégâts est bien ajoutée à l'inventaire.
        public static void TestAddSmallDamagePotion()
        {
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            Console.WriteLine("Inventaire avant ajout de la potion de soin :");
            player.Inventory.DisplayInventory();

            player.AddSmallDamagePotionToInventory();

            Console.WriteLine("Inventaire après ajout de la potion de dégâts :");
            player.Inventory.DisplayInventory();
        }

        // Vérifie qu'une potion de soin "moyenne" est bien ajoutée à l'inventaire.
        public static void TestAddMediumHealPotion()
        {
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            Console.WriteLine("Inventaire avant ajout de la potion de soin :");
            player.Inventory.DisplayInventory();

            player.AddMediumHealPotionToInventory();

            Console.WriteLine("Inventaire après ajout de la potion de soin :");
            player.Inventory.DisplayInventory();
        }

        // Vérifie qu'une potion de dégâts "moyenne" est bien ajoutée à l'inventaire.
        public static void TestAddMediumDamagePotion()
        {
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            Console.WriteLine("Inventaire avant ajout de la potion de soin :");
            player.Inventory.DisplayInventory();

            player.AddMediumDamagePotionToInventory();

            Console.WriteLine("Inventaire après ajout de la potion de dégâts :");
            player.Inventory.DisplayInventory();
        }

        // Vérifie qu'une potion de soin "grande" est bien ajoutée à l'inventaire.
        public static void TestAddLargeHealPotion()
        {
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            Console.WriteLine("Inventaire avant ajout de la potion de soin :");
            player.Inventory.DisplayInventory();

            player.AddLargeHealPotionToInventory();

            Console.WriteLine("Inventaire après ajout de la potion de soin :");
            player.Inventory.DisplayInventory();
        }

        // Vérifie qu'une potion de dégâts "grande" est bien ajoutée à l'inventaire.
        public static void TestAddLargeDamagePotion()
        {
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            Console.WriteLine("Inventaire avant ajout de la potion de soin :");
            player.Inventory.DisplayInventory();

            player.AddLargeDamagePotionToInventory();

            Console.WriteLine("Inventaire après ajout de la potion de dégâts :");
            player.Inventory.DisplayInventory();
        }
    }
}