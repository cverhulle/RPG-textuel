using RPGTextuel.Core;
using RPGTextuel.Core.Characters;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.Game.TestGameUtils
{
    // Cette classe permet de tester GameDisplay
    public static class TestGameDisplay
    {

        // Test de la méthode PrintFramedList avec une liste vide 
        public static void TestPrintFramedListWithEmptyList()
        {
            Console.WriteLine("=== Test de PrintFramedListWithEmptyList ===");
            List<string> elements = new List<string> { };

            Console.WriteLine("Résultat attendu : Message informant que la liste est vide \n");

            Console.WriteLine("=== Résultat obtenu ===");
            GameDisplay.PrintFramedList(elements, item => item, "Objets du joueur", showCount: true);
        }

        // Test de la méthode PrintFramedList sans titre
        public static void TestPrintFramedListWithoutTitle()
        {
            Console.WriteLine("=== Test de PrintFramedListWithoutTitle ===");
            List<string> elements = new List<string> { "Potion de soin", "Potion de dégâts" };

            Console.WriteLine("Résultat attendu : \n 1. Potion de soin \n 2. Potion de dégâts \n \n 2 élément(s) au total. \n ");

            Console.WriteLine("=== Résultat obtenu ===");
            GameDisplay.PrintFramedList(elements, item => item, showCount: true);

            // À l'écran, on doit voir :
            //   1. Potion de soin
            //   2. Potion de dégâts
            // 2 élément(s) au total.
        }

        // Test de la méthode PrintFramedList sans showcount
        public static void TestPrintFramedListWithoutShowcount()
        {
            Console.WriteLine("=== Test de PrintFramedListWithoutShowcount ===");
            List<string> elements = new List<string> { "Potion de soin", "Potion de dégâts" };

            Console.WriteLine("Résultat attendu : \n  ===== OBJETS DU JOUEUR ===== \n 1. Potion de soin \n 2. Potion de dégâts \n ============= \n");

            Console.WriteLine("=== Résultat obtenu ===");
            GameDisplay.PrintFramedList(elements, item => item, showCount: true);

            // À l'écran, tu devrais voir :
            // ===== OBJETS DU JOUEUR =====
            //   1. Potion de soin
            //   2. Potion de dégâts
            // ============================
        }

        // Test de la méthode PrintFramedList avec tous les paramètres
        public static void TestPrintFramedListWithAllParams()
        {
            Console.WriteLine("=== Test de PrintFramedListWithAllParams ===");

            List<string> elements = new List<string> { "Potion de soin", "Potion de dégâts" };

            Console.WriteLine("Résultat attendu : \n  ===== OBJETS DU JOUEUR ===== \n 1. Potion de soin \n 2. Potion de dégâts \n ============= \n 2 élément(s) au total. \n ");

            Console.WriteLine("=== Résultat obtenu ===");
            GameDisplay.PrintFramedList(elements, item => item, "Objets du joueur", showCount: true);

            // À l'écran, tu devrais voir :
            // ===== OBJETS DU JOUEUR =====
            //   1. Potion de soin
            //   2. Potion de dégâts
            // ============================
            // 2 élément(s) au total.
        }

        // Test de la méthode PrintInventory
        public static void TestPrintInventory()
        {
            Console.WriteLine("=== Test de PrintInventory ===");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            Console.WriteLine("Résultat attendu :\n- Affichage de l'inventaire (objets présents)\n- Puis message : Appuyez sur une touche pour continuer...\n");

            Console.WriteLine("=== Résultat obtenu ===");
            GameDisplay.PrintInventory(player);
        }

        // Test de PrintStats avec un player.
        public static void TestPrintStatsWithPlayer()
        {
            Console.WriteLine("=== Test de PrintStatsWithPlayer ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

            Console.WriteLine("\nRésultat attendu :\n- Affichage des statistiques du joueur\n- Puis message : Appuyez sur une touche pour continuer...\n");

            Console.WriteLine("=== Résultat obtenu ===");
            GameDisplay.PrintStats(player);
        }

        // Test de PrintStats avec un ennemi.
        public static void TestPrintStatsWithEnemy()
        {
            Console.WriteLine("=== Test de PrintStatsWithEnemy ===");
            Enemy enemy = EnemyTestFactory.CreateGoblin();

            Console.WriteLine("\nRésultat attendu :\n- Affichage des statistiques de l'ennemi\n- Puis message : Appuyez sur une touche pour continuer...\n");

            Console.WriteLine("=== Résultat obtenu ===");
            GameDisplay.PrintStats(enemy);
        }
    }
}