using RPGTextuel.Core;
using RPGTextuel.Extensions.Characters;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.ExtensionsCharacter
{
    // Cette classe teste les méthodes du dossier Character dans Extensions
    public static class TestCharacterExtensions
    {
        // Cette méthode teste la méthode PrintHealthBar
        public static void TestPrintHealthBarWithFullHealth()
        {
            Console.WriteLine("=== Test : PrintHealthBar avec vie pleine ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            player.PrintHealthBar();
            GameUtils.WaitForUser();
        }

        // Cette méthode teste la méthode PrintHealthBar
        public static void TestPrintHealthBarNotWithFullHealth()
        {
            Console.WriteLine("=== Test : PrintHealthBar avec vie réduite ===");
            Player player = PlayerTestFactory.CreateWoundedPlayer(20);
            player.PrintHealthBar();
            GameUtils.WaitForUser();
        }
    }
}