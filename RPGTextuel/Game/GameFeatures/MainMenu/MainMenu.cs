using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.FightingAnEnemyMenus;

namespace RPGTextuel.Game.GameFeatures.MainMenu
{
    // Cette classe s'occupe de gérer le menu principal.
    // Il apparaît entre chaque combat.
    public static class MainMenu
    {
        // Cette méthode lance la boucle de jeu.
        // Elle retourne, en booléan, l'arrêt, ou non, de la partie.
        public static Boolean HandleMainMenu(Player player, List<Enemy> ennemies)
        {
            // On sauvegarde le nombre d'ennemis que l'on combat.
            int fightNumber = 0;

            // On introduit une variable permettant de dire si l'on affronte le boss final ou non.
            bool isFinalBoss = (fightNumber == ennemies.Count - 1);

            // Pour chaque ennemi dans la liste
            foreach (Enemy enemy in ennemies)
            {
                // Cette méthode s'occupe de gérer les événements entre les combats
                MainMenuUtils.HandleEventsBetweenFights(player, enemy, fightNumber, "Un nouvel ennemi approche");

                // On délègue la gestion du menu principal à une méthode dédiée
                Boolean wantsToQuit = FightingAnEnemyMenu.HandleMainMenu(player, enemy);

                // On "regarde" si la partie doit s'arrêter.
                if (MainMenuUtils.ShouldEndGame(wantsToQuit, player))
                {
                    return true;
                }

                // Après chaque combat, on augmente le compteur de 1.
                fightNumber++;
            }
            return false;
        }
    }
}