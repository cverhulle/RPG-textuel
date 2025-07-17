using RPGTextuel.Core;
using RPGTextuel.Extensions.Characters;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.ExtensionsCharacter
{
    // Cette classe teste les méthodes du dossier Character dans Extensions
    public static class TestCharacterExtensions
    {
        // Cette méthode teste la méthode PrintHealthBar
        public static void TestPrintHealthBar()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();
            player.PrintHealthBar();
        }
    }
}