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
        public static void HandleEventsBetweenFights
        (
            Player player,
            Enemy enemy,
            int fightNumber,
            string messageIntroFight = "Un nouvel ennemi approche",
            bool isFinalBoss = false
        )
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

            // Si l'on affronte le boss final, on personnalise le message.
            if (isFinalBoss)
            {
                GameDisplay.ShowEnemyStatsWithAMessage
                (
                    enemy,
                    $"🔥 Un grondement sourd secoue les environs... \n{enemy.Name} approche ! Le combat final va commencer !"
                );
            }

            // On affiche un message indiquant qu'on passe au combat suivant.
            else
            {
                GameDisplay.ShowEnemyStatsWithAMessage(enemy, messageIntroFight);
            }
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
    }
}