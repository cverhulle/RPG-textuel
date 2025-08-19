using RPGTextuel.Config;
using RPGTextuel.Core;
using RPGTextuel.Extensions.Characters;
using RPGTextuel.RandomEvent.SetupEvent;

namespace RPGTextuel.Test.RandomEvents
{
    // Cette classe regroupe les méthodes d'aide liées aux évenements aléatoires.
    public static class RandomEventsTestsUtils
    {
        // Méthode utilitaire liée à l'évenement FindItemEvent avec les items par défaut.
        public static void FindItemEventUtilsByDefault(Player player)
        {
            Console.WriteLine("Inventaire initial :");
            player.Inventory.DisplayInventory();

            FindItemEvent findItemEvent = new FindItemEvent();
            findItemEvent.Trigger(player);

            Console.WriteLine("Inventaire final :");
            player.Inventory.DisplayInventory();
        }

        // Méthode utilitaire pour tester FindItemEvent avec la table d'objet de boss.
        public static void FindItemEventWithBossItemDrops(Player player)
        {
            Console.WriteLine("Inventaire initial :");
            player.Inventory.DisplayInventory();

            // On utilise la table BossItemDrops
            var customLootTable = ItemDropConfig.BossItemDrops;
            FindItemEvent findItemEvent = new FindItemEvent(customLootTable);
            findItemEvent.Trigger(player);

            Console.WriteLine("Inventaire final :");
            player.Inventory.DisplayInventory();
        }

        // Méthode utilitaire liée à l'événement GainCriticalChancePlayerEvent
        public static void GainCriticalChancePlayerEventUtils(Player player)
        {
            Console.WriteLine($"Chance critique initiale : {player.CriticalHitChance * 100:0.#}%");

            GainCriticalChancePlayerEvent evt = new GainCriticalChancePlayerEvent();
            evt.Trigger(player);
        }

        // Méthode utilitaire liée à l'évenement Gain!healthEvent
        public static void GainHealthEventUtils(Player player)
        {
            Console.WriteLine("Santé initial :");
            player.PrintHealthBar();
            GainHealthEvent gainHealthEvent = new GainHealthEvent();
            gainHealthEvent.Trigger(player);
            Console.WriteLine("Santé final :");
            player.PrintHealthBar();
        }

        // Méthode utilitaire liée à l'événement GainStrengthEvent
        public static void GainStrengthEventUtils(Player player)
        {
            Console.WriteLine($"Force initiale : {player.Strength}");

            GainStrengthEvent evt = new GainStrengthEvent();
            evt.Trigger(player);
        }

        // Méthode utilitaire liée à l'événement LoseCriticalChancePlayerEvent
        public static void LoseCriticalChancePlayerEventUtils(Player player)
        {
            Console.WriteLine($"Chance critique initiale : {player.CriticalHitChance * 100:0.#}%");

            LoseCriticalChancePlayerEvent evt = new LoseCriticalChancePlayerEvent();
            evt.Trigger(player);
        }

        // Méthode utilitaire liée à l'évenement LosehealthEvent
        public static void LoseHealthEventUtils(Player player)
        {
            Console.WriteLine("Santé initial :");
            player.PrintHealthBar();
            LoseHealthEvent loseHealthEvent = new LoseHealthEvent();
            loseHealthEvent.Trigger(player);
            Console.WriteLine("Santé final :");
            player.PrintHealthBar();
        }

        // Méthode utilitaire liée à l'évenement LoseItemEvent
        public static void LoseItemEventUtils(Player player)
        {
            Console.WriteLine("Inventaire initial :");
            player.Inventory.DisplayInventory();
            LoseItemEvent loseItemEvent = new LoseItemEvent();
            loseItemEvent.Trigger(player);
            Console.WriteLine("Inventaire final :");
            player.Inventory.DisplayInventory();
        }

        // Méthode utilitaire liée à l'évenement PeacefulDayEvent
        public static void PeacefulDayEventUtils(Player player)
        {
            Console.WriteLine("Santé initiale :");
            player.PrintHealthBar();
            Console.WriteLine("Inventaire initial :");
            player.Inventory.DisplayInventory();

            PeacefulDayEvent peacefulDayEvent = new PeacefulDayEvent();
            peacefulDayEvent.Trigger(player);

            Console.WriteLine("\nSanté finale :");
            player.PrintHealthBar();
            Console.WriteLine("Inventaire final :");
            player.Inventory.DisplayInventory();
        }
    }
}