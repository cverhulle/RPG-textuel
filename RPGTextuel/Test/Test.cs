// Ce fichier permet de tester les différentes fonctionnalités du programme.
using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.SetupEnemies;

namespace RPGTextuel.Test
{
    public static class TestProgram
    {
        // Cette fonction est la méthode permettant de tester le jeu.
        public static void GameTest()
        {

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
    }
}