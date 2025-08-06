using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.MainMenu;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de tester MainMenuUtils
    public static class TestMainMenuUtils
    {
        // Cette méthode permet de tester HandleBetweenFight quand c'est le premier combat
        // Il ne doit pas y avoir d'événement qui se produit 
        // Seul l'information de l'ennemi apparaît.
        public static void TestHandleBetweenFightWhenItIsFirstFight()
        {
            Console.WriteLine("=== Test de HandleBetweenFightWhenItIsFirstFight ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Enemy enemy = EnemyTestFactory.CreateGoblinChief();
            int fightNumber = 0;
            string messageIntroFight = "Un nouvel ennemi approche";
            bool isFinalBoss = false;

            Console.WriteLine("=== Résultat attendu : Pas d'événement \n Infos de l'ennemi uniquement ===");
            GameUtils.WaitForUser();

            MainMenuUtils.HandleBetweenFights(
                player,
                enemy,
                fightNumber,
                messageIntroFight,
                isFinalBoss
            );
        }

        // Cette méthode permet de tester HandleBetweenFight quand ce n'est pas le premier combat
        // Il doit y avoir un événement qui se produit 
        // L'information de l'ennemi apparaît.
        public static void TestHandleBetweenFightWhenItIsNotFirstFight()
        {
            Console.WriteLine("=== Test de HandleBetweenFightWhenItIsFirstFight ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Enemy enemy = EnemyTestFactory.CreateGoblinChief();
            int fightNumber = 1;
            string messageIntroFight = "Un nouvel ennemi approche";
            bool isFinalBoss = false;

            Console.WriteLine("=== Résultat attendu : Un événement est déclenché \n Infos de l'ennemi ===");
            GameUtils.WaitForUser();

            MainMenuUtils.HandleBetweenFights(
                player,
                enemy,
                fightNumber,
                messageIntroFight,
                isFinalBoss
            );
        }

        // Cette méthode permet de tester HandleBetweenFight quand ce n'est pas le combat de boss.
        // Pas d'événement activé.
        // Le message "Message de test" doit apparâitre avant les infos de l'ennemi
        public static void TestHandleBetweenFightWithStandardEnemy()
        {
            Console.WriteLine("=== Test de HandleBetweenFightWhenItIsFirstFight ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Enemy enemy = EnemyTestFactory.CreateGoblinChief();
            int fightNumber = 1;
            string messageIntroFight = "Message de test";
            bool isFinalBoss = false;

            Console.WriteLine("=== Résultat attendu : Pas d'événement \n Infos de l'ennemi précédé de 'Message de test' ===");
            GameUtils.WaitForUser();

            MainMenuUtils.HandleBetweenFights(
                player,
                enemy,
                fightNumber,
                messageIntroFight,
                isFinalBoss
            );
        }

        
        // Cette méthode permet de tester HandleBetweenFight quand ce est le combat de boss.
        // Pas d'événement activé.
        // Le message de boss doit apparâitre avant les infos de l'ennemi
        public static void TestHandleBetweenFightWithBossEnemy()
        {
            Console.WriteLine("=== Test de HandleBetweenFightWhenItIsFirstFight ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Enemy enemy = EnemyTestFactory.CreateGoblinChief();
            int fightNumber = 1;
            string messageIntroFight = "Message de test";
            bool isFinalBoss = false;

            Console.WriteLine("=== Résultat attendu : Pas d'événement \n Infos de l'ennemi précédé du message d'intro du boss ===");
            GameUtils.WaitForUser();

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