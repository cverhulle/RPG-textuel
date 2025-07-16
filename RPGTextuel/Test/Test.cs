// Ce fichier permet de tester les différentes fonctionnalités du programme.
using RPGTextuel.Core;

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
    }
}