using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.MainMenu;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de tester MainMenuUtils
    public static class TestMainMenuUtils
    {
        // Cette méthode permet de tester HandleBetweenFight quand c'est le premier combat
        public static void TestHandleBetweenFightWhenItIsFirstFight()
        {
            Console.WriteLine("=== Test de HandleBetweenFightWhenItIsFirstFight ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Enemy enemy = EnemyTestFactory.CreateGoblinChief();
            int fightNumber = 0;
            string messageIntroFight = "Un nouvel ennemi approche";
            bool isFinalBoss = false;

            Console.WriteLine("=== Résultat attendu : Pas d'événement \n Infos de l'ennemi uniquement ===");
            MainMenuUtils.HandleBetweenFights(
                player,
                enemy,
                fightNumber,
                messageIntroFight,
                isFinalBoss
            );
        }

        // Cette méthode permet de tester HandleBetweenFight quand ce n'est pas le premier combat
        public static void TestHandleBetweenFightWhenItIsNotFirstFight()
        {
            Console.WriteLine("=== Test de HandleBetweenFightWhenItIsFirstFight ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Enemy enemy = EnemyTestFactory.CreateGoblinChief();
            int fightNumber = 1;
            string messageIntroFight = "Un nouvel ennemi approche";
            bool isFinalBoss = false;

            Console.WriteLine("=== Résultat attendu : Pas d'événement \n Infos de l'ennemi uniquement ===");
            MainMenuUtils.HandleBetweenFights(
                player,
                enemy,
                fightNumber,
                messageIntroFight,
                isFinalBoss
            );
        }

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