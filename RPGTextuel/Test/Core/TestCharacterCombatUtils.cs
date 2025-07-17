using RPGTextuel.Core;
using RPGTextuel.Core.Characters;
using RPGTextuel.Enemies.Class;

namespace RPGTextuel.Test.Core.TestCombat
{
    // Cette classe permet de tester les méthodes de combat de la classe Character
    public static class TestCharacterCombat
    {
        // On teste la méthode TakeDamage.
        public static void TestTakeDamageUtils()
        {
            Character player = TestPlayerFactory.TestPlayerCreation();
            player.TakeDamage(20);
        }

        // On teste la méthode Attack
        public static void TestAttackUtils()
        {
            Character player = TestPlayerFactory.TestPlayerCreation();
            // Enemy enemy = 
        }
    }
}