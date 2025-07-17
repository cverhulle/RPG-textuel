namespace RPGTextuel.Test.Core
{
    // Cette classe permet de tester les méthodes de combat de la classe Character
    public static class TestCharacterCombat
    {
        public static void TestTakeDamage(Character character)
        {
            character.TakeDamage(20);
        }
    }
}