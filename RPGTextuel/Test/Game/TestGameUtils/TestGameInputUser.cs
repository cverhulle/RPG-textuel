using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Test.Game.TestGameUtils
{
    // Cette classe permet de tester GameInputUser
    public static class TestGameInputUser
    {
        // Cette méthode permet de tester AskUserInput.
        public static void TestAskUserInput()
        {
            Console.WriteLine("=== Test de AskUserInput ===");
            string result = GameInputUser.AskUserInput("Quel est ton nom ? ");
            Console.WriteLine($"Tu as tapé : {result}");
        }
    }
}