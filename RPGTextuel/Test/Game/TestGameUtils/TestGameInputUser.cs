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

        // Cette méthode permet de tester AskMenuChoice.
        public static void TestAskMenuChoice()
        {
            Console.WriteLine("=== Test de AskMenuChoice ===");

            List<string> options = new List<string>
            {
                "Explorer",
                "Inventaire",
                "Quitter"
            };

            int result = GameInputUser.AskMenuChoice(options, "MENU PRINCIPAL"); // Tester manuellement différentes possibilités.
            Console.WriteLine($"Tu as choisi l'option numéro : {result}");
        }
    }
}