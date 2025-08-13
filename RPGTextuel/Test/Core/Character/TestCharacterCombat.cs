using RPGTextuel.Enemies.Class;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;
using RPGTextuel.Core;
using RPGTextuel.Extensions.Players;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Extensions.Enemies;

namespace RPGTextuel.Test.CoreCharacter
{
    // Cette classe permet de tester les méthodes de combat de la classe Character
    public static class TestCharacterCombat
    {
        // On teste la méthode TakeDamage.
        public static void TestTakeDamage()
        {
            Console.WriteLine("=== Test : TakeDamage ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();

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
            Console.WriteLine("=== Test : Attack ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Enemy enemy = EnemyTestFactory.CreateGoblinMinion();

            Console.WriteLine("Statistiques initiales :");
            Console.WriteLine(">>> Joueur :");
            player.PrintStats();
            Console.WriteLine(">>> Ennemi :");
            enemy.PrintStats();

            player.Attack(enemy);

            Console.WriteLine("\nStatistiques après attaque :");
            Console.WriteLine(">>> Joueur :");
            player.PrintStats();
            Console.WriteLine(">>> Ennemi :");
            enemy.PrintStats();

            GameUtils.WaitForUser();
        }

        // On teste la méthode Attack avec un critique forcé
        public static void TestAttackWithCriticalHit()
        {
            Console.WriteLine("=== Test : AttackWithCriticalHit ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            Enemy enemy = EnemyTestFactory.CreateGoblinMinion();

            // On met le critique du joueur à 100%
            player.CriticalHitChance = 1;

            Console.WriteLine("Statistiques initiales :");
            Console.WriteLine(">>> Joueur :");
            player.PrintStats();
            Console.WriteLine(">>> Ennemi :");
            enemy.PrintStats();

            Console.WriteLine("Résultat attendu : Affichage du message relatif au coup critique");
            player.Attack(enemy);

            Console.WriteLine("\nStatistiques après attaque :");
            Console.WriteLine(">>> Joueur :");
            player.PrintStats();
            Console.WriteLine(">>> Ennemi :");
            enemy.PrintStats();

            GameUtils.WaitForUser();
        }
    }
}