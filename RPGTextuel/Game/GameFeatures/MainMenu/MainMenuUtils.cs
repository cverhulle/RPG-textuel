using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Game.GameFeatures.RandomEvents;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.MainMenu
{
    // Cette classe s'occupe de gérer les méthodes utilitaires de MainMenu.
    public static class MainMenuUtils
    {
        // Méthode utilitaire pour gérer les événements entre les combats
        public static void HandleEventsBetweenFights(int fightNumber, Player player, Enemy enemy)
        {
            // Déclenche un événement aléatoire avant le combat sauf pour le premier ennemi
            if (fightNumber > 0)
            {
                RandomEventsInGame.TriggerRandomEventWithIntro(
                    player,
                    "Un événement survient avant votre prochain combat..."
                );
                GameUtils.WaitForUser();
            }

            // On affiche un message indiquant qu'on passe au combat suivant.
            ShowEnemyIntroduction(enemy);
        }

        // Méthode utilitaire permettant de savoir si l'on doit arreter la partie.
        // On retourne True si c'est le cas et, false sinon.
        public static bool ShouldEndGame(bool wantsToQuit, Player player)
        {
            if (wantsToQuit)
            {
                CloseGame.CloseTheGame();
                return true;
            }

            if (!player.IsAlive)
            {
                Console.WriteLine("Vous êtes mort. Fin de la partie.");
                return true;
            }
            return false;
        }

        // Méthode utilitaire pour gérer l'introduction du nouvel ennemi entre chaque combat.
        private static void ShowEnemyIntroduction(Enemy enemy)
        {
            Console.Clear();
            Console.WriteLine("Un nouvel ennemi approche !");
            enemy.PrintStats();
            GameUtils.WaitForUser();
        }
    }
}