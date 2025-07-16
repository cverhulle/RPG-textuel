using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Extensions.Players;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.RandomEvents;

namespace RPGTextuel.Test
{
    // Cette classe lance le test.
    public class TestLauncher
    {
        // On lance cette méthode pour tester le programme.
        public void TestLauncherMain()
        {
            TestFindAndLoseItemEvents();
        }

        // Cette méthode permet de tester la méthode SetupPlayerAndGoblinAndSmallHealAndDamagePotion.
        private void TestSetupPlayerAndGoblinAndSmallHealAndDamagePotion()
        {
            (Player player, Enemy enemy) = TestUtils.SetupPlayerAndGoblinAndSmallHealAndDamagePotion();
            player.PrintStats();
            player.Inventory.DisplayInventory();
            enemy.PrintStats();
        }

        // Cette méthode permet de tester les 2 évenements liés aux objets.
        private void TestFindAndLoseItemEvents()
        {
            Player player = TestPlayerFactory.SetupPlayerAndSmallHealAndDamagePotion();

            Console.WriteLine("Inventaire initial :");
            player.Inventory.DisplayInventory();

            Console.WriteLine("\n Événement : Trouver un objet");
            TestRandomEvents.TestFindItemEvent(player);

            Console.WriteLine("\n Événement : Perdre un objet");
            TestRandomEvents.TestLoseItemEvent(player);

            GameUtils.WaitForUser();
        }
    }
}