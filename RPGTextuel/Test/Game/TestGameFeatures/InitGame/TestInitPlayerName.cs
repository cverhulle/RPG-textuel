using RPGTextuel.Config;
using RPGTextuel.Game.GameFeatures.InitGame;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de tester InitPlayerName
    public static class TestInitPlayerName
    {
        // Cette méthode permet de lancer AskAndVerifyPlayerName pour tester son fonctionnement
        public static void FakeTestAskAndVerifyPlayerName()
        {
            string name = InitPlayerName.AskAndVerifyPlayerName();
            Console.WriteLine($"Nom du joueur retenu : {name}");
        }

        // Cette méthode permet de tester VerifyPlayerName
        public static void TestVerifyPlayerName()
        {
            Console.WriteLine("=== Test de VerifyPlayerName ===");

            // Cas 1 : Nom vide
            string name1 = "";
            bool result1 = InitPlayerName.VerifyPlayerName(name1);
            Console.WriteLine($"Nom : '{name1}' => {(result1 ? "Invalide (attendu)" : "Valide (non attendu)")}");

            // Cas 2 : Nom avec espaces
            string name2 = "    ";
            bool result2 = InitPlayerName.VerifyPlayerName(name2);
            Console.WriteLine($"Nom : '{name2}' => {(result2 ? "Invalide (attendu)" : "Valide (non attendu)")}");

            // Cas 3 : Nom trop long
            string name3 = new string('A', GameConfig.MaxNameLength + 1);
            bool result3 = InitPlayerName.VerifyPlayerName(name3);
            Console.WriteLine($"Nom : '{name3}' => {(result3 ? "Invalide (attendu)" : "Valide (non attendu)")}");

            // Cas 4 : Nom valide
            string name4 = "Alice";
            bool result4 = InitPlayerName.VerifyPlayerName(name4);
            Console.WriteLine($"Nom : '{name4}' => {(result4 ? "Invalide (non attendu)" : "Valide (attendu)")}");

            // Cas 5 : Nom limite exact
            string name5 = new string('B', GameConfig.MaxNameLength);
            bool result5 = InitPlayerName.VerifyPlayerName(name5);
            Console.WriteLine($"Nom : '{name5}' => {(result5 ? "Invalide (non attendu)" : "Valide (attendu)")}");
        }
    }
}