using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.Fight;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de teset BattleDisplay
    public static class TestBattleDisplay
    {
        // Cette méthode permet de tester ShowBattleState
        public static void TestShowBattleState()
        {
            Console.WriteLine("=== Test de ShowBattleState avec un joueur blessé et un ennemi full HP ===");

            Player player = PlayerTestFactory.CreateWoundedPlayer(20);
            Enemy enemy = EnemyTestFactory.CreateGoblinMinion();

            Console.WriteLine("Résultat attendu : affichage des barres de santé du joueur et de l'ennemi.");
            BattleDisplay.ShowBattleState(player, enemy);
        }

        // Cette méthode permet de tester ShowBattleResult dans le cas d'une victoire
        public static void TestShowBattleResult_Victory()
        {
            Console.WriteLine("=== Test de ShowBattleResult : Victoire ===");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Enemy enemy = EnemyTestFactory.CreateDeadGoblin();

            BattleDisplay.ShowBattleResult(player, enemy);
        }

        // Cette méthode permet de tester ShowBattleResult dans le cas d'une défaite
        public static void TestShowBattleResult_Defeat()
        {
            Console.WriteLine("=== Test de ShowBattleResult : Défaite ===");

            Player player = PlayerTestFactory.CreateDeadPlayer();
            Enemy enemy = EnemyTestFactory.CreateGoblinChief();

            BattleDisplay.ShowBattleResult(player, enemy);
        }

        // Cette méthode permet de tester ShowBattleResult dans le cas d'erreur
        public static void TestShowBattleResult_Error()
        {
            Console.WriteLine("=== Test de ShowBattleResult : Erreur de logique ===");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Enemy enemy = EnemyTestFactory.CreateGoblinMinion();

            BattleDisplay.ShowBattleResult(player, enemy);
        }
    }
}