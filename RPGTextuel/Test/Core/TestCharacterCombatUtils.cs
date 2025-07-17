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

        // On teste la méthode Attack
        public static void TestAttack(Character character1, Character character2)
        {
            character1.Attack(character2);
        }
    }
}