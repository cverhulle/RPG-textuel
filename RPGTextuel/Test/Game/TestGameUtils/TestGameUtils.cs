using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Test.Game.TestGameUtils
{
    // Cette classe permet de tester GameUtils
    public static class TestGameUtils
    {
        // On teste la méthode isBackChoiceWithList.
        public static void TestIsBackChoiceWithList()
        {
            Console.WriteLine("=== Test IsBackChoiceWithList ===");
            List<string> options = new List<string> { "Option 1", "Option 2", "Option 3" };

            bool backChoice = GameUtils.IsBackChoiceWithList(3, options);
            bool notBackChoice = GameUtils.IsBackChoiceWithList(1, options);

            Console.WriteLine($"Retour attendu : true → Résultat obtenu : {backChoice}");
            Console.WriteLine($"Retour attendu : false → Résultat obtenu : {notBackChoice}");
        }
    }
}