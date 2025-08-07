using RPGTextuel.Enemies.Class;
using RPGTextuel.SetupEnemies;

namespace RPGTextuel.Test.Enemies
{
    // Fournit des instances d'ennemis prédéfinis pour les tests.
    public static class EnemyTestFactory
    {
        // Cette fonction permet de créer un ennemi de type Gobelin
        public static Goblin CreateGoblin()
        {
            return SetupGoblins.GetRandomGoblin();
        }

        // Cette fonction permet de créer un ennemi de type Petit Gobelin
        public static GoblinMinion CreateGoblinMinion()
        {
            return SetupGoblinMinions.GetRandomGoblinMinion();
        }

        // Cette fonction permet de créer un ennemi de type Chef Gobelin
        public static GoblinChief CreateGoblinChief()
        {
            return SetupGoblinChiefs.GetRandomGoblinChief();
        }

        // Cette fonction permet de créer un ennemi de type RedDragon
        public static RedDragon CreateRedDragon()
        {
            return SetupRedDragons.GetRandomRedDragon();
        }

        // Cette fonction crée un Petit Gobelin endommagé.
        public static Enemy CreateWeakGoblinMinion()
        {
            GoblinMinion weakGoblinMinion = CreateGoblinMinion();
            weakGoblinMinion.TakeDamage(10);
            return weakGoblinMinion;
        }

        // Cette méthode permet de créer un Gobelin mort.
        public static Enemy CreateDeadGoblin()
        {
            Enemy enemy = new Goblin("Gobelin mort", 0, 5, 20); 
            return enemy;
        }
    }
}