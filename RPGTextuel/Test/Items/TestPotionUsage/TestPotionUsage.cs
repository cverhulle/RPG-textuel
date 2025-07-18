using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Characters;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.Items
{
    // Cette classe teste les méthodes "Use" des potions.
    public static class TestPotionUsage
    {
        // Test de la potion de soin sur un personnage bléssé.
        public static void TestHealPotionOnWoundedPlayer()
        {
            Console.WriteLine("=== Test de HealPotion sur un personnage blessé ===");
            Player player = PlayerTestFactory.CreateWoundedPlayerWithPotions(40);

            Console.WriteLine("=== Etat avant l'utilisation ===");
            player.PrintHealthBar();


            Boolean isPotionUsed = player.Inventory.UseItem(0, player, player);
            Console.WriteLine($"La potion a-t-elle été utilisée ? (attendu : true): {isPotionUsed}");
            player.PrintHealthBar(); // Les PV ont remonté
        }

        // Test de HealPotion sur un personnage avec la vie pleine
        public static void TestHealPotionWithFullHealth()
        {
            Console.WriteLine("=== Test de HealPotion sur un personnage avec vie pleine ===");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            Console.WriteLine("=== Etat avant l'utilisation ===");
            player.PrintHealthBar();

            Boolean isPotionUsed = player.Inventory.UseItem(0, player, player);
            Console.WriteLine($"La potion a-t-elle été utilisée ? (attendu : false): {isPotionUsed}");
            player.PrintHealthBar(); // Pas de changement attendu.
        }

        // Test de DamagePotion sur un ennemi
        public static void TestDamagePotionOnEnemy()
        {
            Console.WriteLine("=== Test de DamagePotion sur un ennemi ==");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();
            Goblin goblin = EnemyTestFactory.CreateGoblin();

            Console.WriteLine("=== Etat avant l'utilisation ===");
            goblin.PrintHealthBar();

            Boolean isPotionUsed = player.Inventory.UseItem(1, player, goblin);
            Console.WriteLine($"La potion a-t-elle été utilisée ? (attendu : true): {isPotionUsed}");
            player.PrintHealthBar(); // Les PV ont diminué.
        }

        // Test de DamagePotion sur soi-même
        public static void TestDamagePotionOnSelf()
        {
            Console.WriteLine("=== Test de DamagePotion sur un soi-même ==");
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();

            Console.WriteLine("=== Etat avant l'utilisation ===");
            player.PrintHealthBar();

            Boolean isPotionUsed = player.Inventory.UseItem(1, player, player);
            Console.WriteLine($"La potion a-t-elle été utilisée ? (attendu : false): {isPotionUsed}");
            player.PrintHealthBar(); // Pas changement attendu.
        }
    }
}