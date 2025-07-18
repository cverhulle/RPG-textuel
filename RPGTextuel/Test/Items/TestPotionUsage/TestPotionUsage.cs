using RPGTextuel.Core;
using RPGTextuel.Extensions.Characters;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.Items
{
    // Cette classe teste les méthodes "Use" des potions.
    public static class TestPotionUsage
    {
        // Test de la potion de soin sur un personnage bléssé.
        public static void TestHealPotionOnWoundedPlayer()
        {
            Console.WriteLine("=== Test de HealPotion sur un personnage blessé ===");
            Player player = PlayerTestFactory.CreateWoundedPlayerWithPotions(20);

            Console.WriteLine("=== Etat avant l'utilisation ===");
            player.PrintHealthBar();


            Boolean isPotionUsed = player.Inventory.UseItem(0, player, player);
            Console.WriteLine($"La potion a-t-elle été utilisée ? (attendu : true): {isPotionUsed}");
            player.PrintHealthBar(); // Pas de changement attendu.
        }

        /*
        // Test de HealPotion sur un personnage avec la vie pleine
        public static void TestHealPotionOnFullHealthAlly()
        {
            Player user = PlayerTestFactory.CreatePlayer();
            Player target = PlayerTestFactory.CreatePlayer();

            HealPotion potion = new HealPotion(PotionSize.Small);
            bool result = potion.Use(user, target);

            Console.WriteLine($"Résultat de l'utilisation : {result}");
            target.PrintHealthBar();
        }

        // Test de DamagePotion sur un ennemi
        public static void TestDamagePotionOnEnemy()
        {
            Player user = PlayerTestFactory.CreatePlayer();
            Enemy enemy = EnemyTestFactory.CreateGoblin();

            DamagePotion potion = new DamagePotion(PotionSize.Small);
            bool result = potion.Use(user, enemy);

            Console.WriteLine($"Résultat de l'utilisation : {result}");
            enemy.PrintStats();
        }

        // Test de DamagePotion sur soi-même
        public static void TestDamagePotionOnSelf()
        {
            Player user = PlayerTestFactory.CreatePlayer();

            DamagePotion potion = new DamagePotion(PotionSize.Small);
            bool result = potion.Use(user, user);

            Console.WriteLine($"Résultat de l'utilisation : {result}");
            user.PrintStats();
        }
        */
    }
}