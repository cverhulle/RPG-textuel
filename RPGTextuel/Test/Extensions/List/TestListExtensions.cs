using RPGTextuel.Extensions.List;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Test.ExtensionsList
{
    // Cette classe teste les méthodes du dossier Extensions, fichier List
    public static class TestListExtensions
    {
        // Cette méthode teste la méthode PickRandom sur une liste vide.
        public static void TestPickRandomWithEmptyList()
        {
            Console.WriteLine("=== Test : PickRandom sur une liste vide ===");
            try
            {
                List<string> emptyList = new List<string>();
                var result = emptyList.PickRandom();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Succès : Exception levée comme attendu.");
            }
            catch (Exception)
            {
                Console.WriteLine("ÉCHEC : Mauvais type d'exception levée.");
            }

            GameUtils.WaitForUser();
        }

        // Cette méthode teste PickRandom avec une liste non vide.
        public static void TestPickRandomWithNonEmptyList()
        {
            Console.WriteLine("=== Test : PickRandom sur une liste non vide ===");

            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "Diana" };

            // On appele PickRandom plusieurs fois pour observer le comportement.
            for (int i = 0; i < 5; i++)
            {
                string picked = names.PickRandom();
                Console.WriteLine($"Tirage {i + 1} : {picked}");
            }
            GameUtils.WaitForUser();
        }
    }
}