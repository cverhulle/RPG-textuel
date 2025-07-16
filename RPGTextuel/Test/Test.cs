// Ce fichier permet de tester les différentes fonctionnalités du programme.
using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Players;
using RPGTextuel.Items.Consumables;
using RPGTextuel.Items.SetupItems;
using RPGTextuel.SetupEnemies;

namespace RPGTextuel.Test
{
    public static class TestProgram
    {
        // Cette fonction permet de créer le joueur, un ennemi de type Goblin
        // et d'ajouter une potion de soin et de dégats au joeur
        public static (Player, Enemy) SetupPlayerAndGoblinAndSmallHealAndDamagePotion()
        {
            Player player = TestPlayerCreation();
            Enemy enemy = TestGoblinEnemyCreation();
            player.TestAddingSmallDamagePotion();
            player.TestAddingSmallHealPotion();
            return (player, enemy);
        }

        // Cette fonction permet de créer un personnage nommé Link
        public static Player TestPlayerCreation()
        {
            return new Player("Link");
        }

        // Cette fonction permet de créer un ennemi de type Gobelin
        public static Enemy TestGoblinEnemyCreation()
        {
            return SetupGoblins.GetRandomGoblin();
        }

        // Cette fonction permet d'ajouter une potion de soin de taille petite dans l'inventaire
        public static void TestAddingSmallHealPotion(this Player player)
        {
            player.AddHealPotion(PotionSize.Small);
        }

        // Cette fonction permet d'ajouter une potion de soin de taille petite dans l'inventaire
        public static void TestAddingSmallDamagePotion(this Player player)
        {
            player.AddDamagePotion(PotionSize.Small);
        }
    }
}