using RPGTextuel.Config;
using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.RandomEvents;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.MainMenu
{
    // Cette classe s'occupe de gérer les méthodes utilitaires de MainMenu.
    public static class MainMenuUtils
    {
        // Méthode utilitaire pour la gestion avant un combat.
        public static void HandleBetweenFights
        (
            Player player,
            Enemy enemy,
            int fightNumber,
            string messageIntroFight = "Un nouvel ennemi approche",
            bool isFinalBoss = false
        )
        {
            // On déclenche un événement avant chaque combat sauf le premier.
            HandleEventsBetweenFights(player, enemy, fightNumber);

            // Si le joueur est mort, on quitte la boucle
            if (!player.IsAlive)
            {
                return;
            }

            // On présente le nouvel ennemi
            HandleEnemyPresentation(enemy, messageIntroFight, isFinalBoss);
        }

        // Cette méthode permet de gérer l'affichage de l'introduction de l'ennemi
        private static void HandleEnemyPresentation(
            Enemy enemy,
            string messageIntroFight = "Un nouvel ennemi approche",
            bool isFinalBoss = false 
        )
        {
            // Si l'on affronte le boss final, on personnalise le message.
            if (isFinalBoss)
            {
                GameDisplay.ShowEnemyStatsWithAMessage
                (
                    enemy,
                    $"🔥 Un grondement sourd secoue les environs... \n{enemy.Name} approche ! Le combat final va commencer ! 🔥",
                    color: TextColorConfig.bossColor
                );
            }

            // On affiche un message indiquant qu'on passe au combat suivant.
            else
            {
                GameDisplay.ShowEnemyStatsWithAMessage(enemy, messageIntroFight, TextColorConfig.ennemiesColor);
            }
        }

        // Cette méthode permet de déclencher un événement aléatoire avant le combat sauf pour le premier ennemi
        private static void HandleEventsBetweenFights(Player player, Enemy enemy, int fightNumber)
        {
            if (fightNumber > 0)
            {
                RandomEventsInGame.TriggerRandomEventWithIntro(
                    player,
                    enemy,
                    "Un événement survient avant votre prochain combat..."
                );
                GameUtils.WaitForUser(color : TextColorConfig.eventsColor);
            }
        }
    }
}