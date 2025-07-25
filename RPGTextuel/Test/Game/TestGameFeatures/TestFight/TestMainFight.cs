using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.Fight;
using RPGTextuel.Test.Core;
using RPGTextuel.Test.Enemies;

namespace RPGTextuel.Test.Game.TestGameFeatures
{
    // Cette classe permet de tester le fichier MainFight
    public static class TesTMainFight
    {
        // Cette méthode permet de lancer HandleBattle.
        // Pas vraiment un test
        public static void FakeTestHandleBattle()
        {
            Player player = PlayerTestFactory.CreatePlayerWithHealAndDamagePotions();
            Enemy enemy = EnemyTestFactory.CreateGoblin();

            MainFight.HandleBattle(player, enemy);
        }
    }
}