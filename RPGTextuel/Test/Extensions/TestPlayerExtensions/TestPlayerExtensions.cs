using RPGTextuel.Core;
using RPGTextuel.Extensions.Players;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.ExtensionsPlayer
{
    // Cette classe teste les méthodes du dossier Player dans Extensions
    public static class TestPlayerExtensions
    {
        // Cette méthode teste la méthode PrintStats
        public static void TestPrintStats()
        {
            Console.WriteLine("=== Test : PrintStats (Player) ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            player.PrintStats();
            GameUtils.WaitForUser();
        }
    }
}