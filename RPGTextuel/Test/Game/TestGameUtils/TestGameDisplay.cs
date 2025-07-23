using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Test.Game.TestGameUtils
{
    // Cette classe permet de tester GameDisplay
    public static class TestGameDisplay
    {

        // Test de la méthode PrintFramedList avec une liste vide 
        public static void TestPrintFramedListWithEmptyList()
        {
            Console.WriteLine("=== Test de PrintFramedListWithEmptyList ===");
            List<string> elements = new List<string> {};

            Console.WriteLine("Résultat attendu : Message informant que la liste est vide \n Résultat obtenu :");
            GameDisplay.PrintFramedList(elements, item => item, "Objets du joueur", showCount: true);
        }

        // Test de la méthode PrintFramedList
        public static void TestPrintFramedList()
        {
            Console.WriteLine("=== Test de PrintFramedList ===");

            List<string> elements = new List<string> { "Potion de soin", "Potion de dégâts" };
            GameDisplay.PrintFramedList(elements, item => item, "Objets du joueur", showCount: true);

            // À l'écran, on doit voir :
            // ===== OBJETS DU JOUEUR =====
            //   1. Potion de soin
            //   2. Potion de dégâts
            // ===== Obj... =====
            // 2 élément(s) au total.
        }
    }

}