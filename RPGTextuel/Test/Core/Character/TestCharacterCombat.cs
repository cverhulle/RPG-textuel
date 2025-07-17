using RPGTextuel.Core.Characters;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.CoreCharacter
{
    // Cette classe permet de tester les méthodes de combat de la classe Character
    public static class TestCharacterCombat
    {
        // On teste la méthode TakeDamage.
        public static void TestTakeDamage()
        {
            Character player = TestPlayerFactory.TestPlayerCreation();
            player.TakeDamage(20);
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