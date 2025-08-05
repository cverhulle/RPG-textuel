using RPGTextuel.Core;
using RPGTextuel.Game.GameFeatures.MainMenu;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de tester MainMenuUtils
    public static class TestMainMenuUtils
    {
        // Cette méthode permet de tester ShouldEndGame quand le jeu doit continuer
        public static void TestShouldEndGameWhenGameShouldContinue()
        {
            Console.WriteLine("=== Test de ShouldEndGameWhenGameShouldContinue ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            bool wantsToQuit = false;

            bool result = MainMenuUtils.ShouldEndGame(wantsToQuit, player);

            Console.WriteLine($"Résultat attendu : false ; Résultat obtenu {result}");
        }

        // Cette méthode permet de tester ShouldEndGame quand le joueur est mort
        public static void TestShouldEndGameWhenPlayerIsDead()
        {
            Console.WriteLine("=== Test de ShouldEndGameWhenPlayerIsDead ===");
            Player player = PlayerTestFactory.CreateDeadPlayer();
            bool wantsToQuit = false;

            bool result = MainMenuUtils.ShouldEndGame(wantsToQuit, player);

            Console.WriteLine($"Résultat attendu : true ; Résultat obtenu {result}");
        }

        // Cette méthode permet de tester ShouldEndGame quand le joueur veut quitter
        public static void TestShouldEndGameWhenPlayerWantsToQuit()
        {
            Console.WriteLine("=== Test de ShouldEndGameWhenPlayerWantsToQuit ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            bool wantsToQuit = true;

            Console.WriteLine($"Résultat attendu : Message de sortie du jeu");
            bool result = MainMenuUtils.ShouldEndGame(wantsToQuit, player);

            Console.WriteLine($"Résultat attendu : true ; Résultat obtenu {result}");
        }
    }
}