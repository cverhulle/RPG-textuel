using RPGTextuel.Config.Enum;
using RPGTextuel.Core;
using RPGTextuel.Extensions.Characters;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.RandomEvent.Class;
using RPGTextuel.RandomEvent.Factory;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.RandomEvents.Factory
{
    // Cette classe regroupe les tests liés à la factory des événements aléatoires.
    public static class TestRandomEventFactory
    {
        // Méthode utilitaire pour tester l'obtention d'un événement aléatoire via la factory
        private static void RandomEventFactoryTestUtils(Player player, ItemDropTableType dropType = ItemDropTableType.Default)
        {
            Console.WriteLine("Santé initiale :");
            player.PrintHealthBar();
            Console.WriteLine("Inventaire initial :");
            player.Inventory.DisplayInventory();

            PlayerRandomEventClass randomEvent = RandomEventFactory.GetRandomEvent(dropType);

            Console.WriteLine($"\n🎲 Événement déclenché : {randomEvent.Name}");
            Console.WriteLine($"{randomEvent.Description}\n");

            randomEvent.Trigger(player);

            Console.WriteLine("\nSanté après événement :");
            player.PrintHealthBar();
            Console.WriteLine("Inventaire après événement :");
            player.Inventory.DisplayInventory();
        }

        // Cette méthode permet de tester un événement aléatoire parmi tous ceux définis
        // On choisit les loot par défaut.
        public static void TestRandomEventFactoryDefaultLoot()
        {
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            RandomEventFactoryTestUtils(player, ItemDropTableType.Default);

            GameUtils.WaitForUser();
        }

        // Cette méthode permet de tester un événement aléatoire parmi tous ceux définis
        // On choisit les loot de boss.
        public static void TestRandomEventFactoryBossLoot()
        {
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            RandomEventFactoryTestUtils(player, ItemDropTableType.Boss);

            GameUtils.WaitForUser();
        }
    }
}