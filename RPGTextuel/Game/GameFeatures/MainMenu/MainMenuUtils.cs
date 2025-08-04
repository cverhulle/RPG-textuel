using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.MainMenu
{
    // Cette classe s'occupe de gérer les méthodes utilitaires de MainMenu.
    public static class MainMenuUtils
    {
        // Méthode utilitaire pour gérer l'introduction du nouvel ennemi entre chaque combat.
        public static void ShowEnemyIntroduction(Enemy enemy)
        {
            Console.Clear();
            Console.WriteLine("Un nouvel ennemi approche !");
            enemy.PrintStats();
            GameUtils.WaitForUser();
        }
    }
}