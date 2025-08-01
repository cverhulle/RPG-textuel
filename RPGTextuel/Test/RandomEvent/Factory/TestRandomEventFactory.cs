using RPGTextuel.Config.Enum;
using RPGTextuel.Core;
using RPGTextuel.Extensions.Characters;
using RPGTextuel.RandomEvent.Class;
using RPGTextuel.RandomEvent.Factory;

namespace RPGTextuel.Test.RandomEvents.Factory
{
    // Cette classe regroupe les tests liés à la factory des événements aléatoires.
    public static class TestRandomEventFactory
    {
        // Méthode utilitaire pour tester l'obtention d'un événement aléatoire via la factory
        public static void RandomEventFactoryTestUtils(Player player, ItemDropTableType dropType = ItemDropTableType.Default)
        {
            Console.WriteLine("Santé initiale :");
            player.PrintHealthBar();
            Console.WriteLine("Inventaire initial :");
            player.Inventory.DisplayInventory();

            RandomEventClass randomEvent = RandomEventFactory.GetRandomEvent(dropType);

            Console.WriteLine($"\n🎲 Événement déclenché : {randomEvent.Name}");
            Console.WriteLine($"{randomEvent.Description}\n");

            randomEvent.Trigger(player);

            Console.WriteLine("\nSanté après événement :");
            player.PrintHealthBar();
            Console.WriteLine("Inventaire après événement :");
            player.Inventory.DisplayInventory();
        }
    }
}