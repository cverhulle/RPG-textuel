using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.FightingAnEnemyMenus;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de tester FightingAnEnemyMenu
    public static class TestFightingAnEnemyMenu
    {
        // Cette méthode permet de lancer HandleMainMenu pour le tester
        public static void FakeTestHandleMainMenu()
        {
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();
            Enemy enemy = EnemyTestFactory.CreateGoblin();

            FightingAnEnemyMenu.HandleMainMenu(player, enemy);
        }
    }
}