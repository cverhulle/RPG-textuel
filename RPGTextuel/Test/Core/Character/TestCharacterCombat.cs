using RPGTextuel.Core.Characters;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;
using RPGTextuel.Core;
using RPGTextuel.Extensions.Players;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Test.CoreCharacter
{
    // Cette classe permet de tester les méthodes de combat de la classe Character
    public static class TestCharacterCombat
    {
        // On teste la méthode TakeDamage.
        public static void TestTakeDamage()
        {
            Console.WriteLine("=== Test : TakeDamage ===");
            Player player = TestPlayerFactory.TestPlayerCreation();

            Console.WriteLine("Avant dégât :");
            player.PrintStats();

            player.TakeDamage(20);

            Console.WriteLine("\nAprès avoir pris 20 dégâts :");
            player.PrintStats();

            GameUtils.WaitForUser();
        }

        // On teste la méthode Attack
        public static void TestAttack()
        {
            Character player = TestPlayerFactory.TestPlayerCreation();
            Enemy enemy = TestEnememyFactory.TestGoblinMinionEnemyCreation();
            player.Attack(enemy);
        }
    }
}