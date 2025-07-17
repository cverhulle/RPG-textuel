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
    }
}