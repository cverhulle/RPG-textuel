using RPGTextuel.Core.Characters;

namespace RPGTextuel.Test.Core
{
    // Cette classe permet de tester les méthodes de combat de la classe Character
    public static class TestCharacterCombat
    {
        // On teste la méthode TakeDamage.
        public static void TestTakeDamage(Character character)
        {
            character.TakeDamage(20);
        }
    }
}