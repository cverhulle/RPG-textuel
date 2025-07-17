using RPGTextuel.Core;
using RPGTextuel.Extensions.Characters;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.ExtensionsCharacter
{
    // Cette classe teste les méthodes du dossier Character dans Extensions
    public static class TestCharacterExtensions
    {
        // Cette méthode teste la méthode PrintHealthBar
        public static void TestPrintHealthBarWithFullHealth()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();
            player.PrintHealthBar();
        }

        // Cette méthode teste la méthode PrintHealthBar
        public static void TestPrintHealthBarNotWithFullHealth()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();
            player.TakeDamage(20);
            player.PrintHealthBar();
        }
    }
}