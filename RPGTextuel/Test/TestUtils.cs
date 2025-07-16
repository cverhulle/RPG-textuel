using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;
using RPGTextuel.Test.Items;

// Ce fichier permet de regrouper des méthodes utiles pour les tests.
namespace RPGTextuel.Test
{
    public static class TestUtils
    {
        // Cette fonction permet de créer le joueur et un ennemi de type Goblin
        public static (Player, Enemy) SetupPlayerAndGoblin()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();
            Enemy enemy = TestEnememyFactory.TestGoblinEnemyCreation();
            return (player, enemy);
        }

        // Cette fonction permet de créer le joueur, un ennemi de type Goblin
        // et d'ajouter une potion de soin et de dégats au joeur
        public static (Player, Enemy) SetupPlayerAndGoblinAndSmallHealAndDamagePotion()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();
            Enemy enemy = TestEnememyFactory.TestGoblinEnemyCreation();
            player.TestAddingSmallDamagePotion();
            player.TestAddingSmallHealPotion();
            return (player, enemy);
        }
    }
}