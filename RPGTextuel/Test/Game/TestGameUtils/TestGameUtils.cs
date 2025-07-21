using RPGTextuel.Config;
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

            Console.WriteLine($"Retour attendu : true → Résultat obtenu : {GameUtils.IsBackChoiceWithList(3, options)}");
            Console.WriteLine($"Retour attendu : false → Résultat obtenu : {GameUtils.IsBackChoiceWithList(1, options)}");
        }

        // On teste isNameNullOrWhiteSpace
        public static void TestIsNameNullOrWhiteSpace()
        {
            Console.WriteLine("=== Test IsNameNullOrWhiteSpace ===");

            Console.WriteLine($"Retour attendu : true → Résultat obtenu : {GameUtils.IsNameNullOrWhiteSpace(null)}");
            Console.WriteLine($"Retour attendu : true → Résultat obtenu : {GameUtils.IsNameNullOrWhiteSpace("")}");
            Console.WriteLine($"Retour attendu : false → Résultat obtenu : {GameUtils.IsNameNullOrWhiteSpace("   ")}");
            Console.WriteLine($"Retour attendu : false → Résultat obtenu : {GameUtils.IsNameNullOrWhiteSpace("Zelda")}");
        }

        // Test de la méthode isnameTooLong
        public static void TestIsNameTooLong()
        {
            Console.WriteLine("=== Test IsNameTooLong ===");

            string validName = "Jean";
            string longName = new string('a', GameConfig.MaxNameLength + 1);

            Console.WriteLine($"Retour attendu : false → Résultat obtenu : {GameUtils.IsNameTooLong(validName)}");
            Console.WriteLine($"Retour attendu : true → Résultat obtenu : {GameUtils.IsNameTooLong(longName)}");
        }

        // Test de isValidMenuChoice
        public static void TestIsValidMenuChoice()
            {
                Console.WriteLine("=== Test IsValidMenuChoice ===");

                int choice;

                Console.WriteLine($"Retour attendu : true → Résultat obtenu : {GameUtils.IsValidMenuChoice("1", 3, out choice)}");  
                Console.WriteLine($"Retour attendu : false → Résultat obtenu : {GameUtils.IsValidMenuChoice("0", 3, out choice)}"); 
                Console.WriteLine($"Retour attendu : false → Résultat obtenu : {GameUtils.IsValidMenuChoice("abc", 3, out choice)}"); 
                Console.WriteLine($"Retour attendu : false → Résultat obtenu : {GameUtils.IsValidMenuChoice("4", 3, out choice)}");   
            }
    }
}