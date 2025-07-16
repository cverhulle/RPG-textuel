using RPGTextuel.Enemies.Class;
using RPGTextuel.SetupEnemies;

namespace RPGTextuel.Test.Enemies
{
    // Cette classe regroupe les tests liés aux ennemis
    public static class TestEnememyFactory
    {
        // Cette fonction permet de créer un ennemi de type Gobelin
        public static Enemy TestGoblinEnemyCreation()
        {
            return SetupGoblins.GetRandomGoblin();
        }

        // Cette fonction permet de créer un ennemi de type Petit Gobelin
        public static Enemy TestGoblinMinionEnemyCreation()
        {
            return SetupGoblinMinions.GetRandomGoblinMinion();
        }

        // Cette fonction permet de créer un ennemi de type Chef Gobelin
        public static Enemy TestGoblinChiefEnemyCreation()
        {
            return SetupGoblinChiefs.GetRandomGoblinChief();
        }
    }
}