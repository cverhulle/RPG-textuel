using RPGTextuel.Core;
using RPGTextuel.Extensions.Characters;
using RPGTextuel.RandomEvent.SetupEvent;

namespace RPGTextuel.Test.RandomEvents
{
    // Cette classe permet de tester les évenements aléatoires.
    public static class TestRandomEvents
    {
        // Cette méthode permet de tester l'évenement FindItemEvent
        public static void TestFindItemEvent(Player player)
        {
            Console.WriteLine("Inventaire initial :");
            player.Inventory.DisplayInventory();
            FindItemEvent findItemEvent = new FindItemEvent();
            findItemEvent.Trigger(player);
            Console.WriteLine("Inventaire final :");
            player.Inventory.DisplayInventory();
        }

        // Cette méthode permet de tester l'évenement LoseItemEvent
        public static void TestLoseItemEvent(Player player)
        {
            Console.WriteLine("Inventaire initial :");
            player.Inventory.DisplayInventory();
            LoseItemEvent loseItemEvent = new LoseItemEvent();
            loseItemEvent.Trigger(player);
            Console.WriteLine("Inventaire final :");
            player.Inventory.DisplayInventory();
        }

        // Cette méthode permet de tester l'évenement GainHealthEvent
        public static void TestGainHealthEvent(Player player)
        {
            Console.WriteLine("Santé initial :");
            player.PrintHealthBar();
            GainHealthEvent gainHealthEvent = new GainHealthEvent();
            gainHealthEvent.Trigger(player);
            Console.WriteLine("Santé final :");
            player.PrintHealthBar();
        }

        // Cette méthode permet de tester l'évenement LoseHealthEvent
        public static void TestLoseHealthEvent(Player player)
        {
            Console.WriteLine("Santé initial :");
            player.PrintHealthBar();
            LoseHealthEvent loseHealthEvent = new LoseHealthEvent();
            loseHealthEvent.Trigger(player);
            Console.WriteLine("Santé final :");
            player.PrintHealthBar();
        }
        
    }
}