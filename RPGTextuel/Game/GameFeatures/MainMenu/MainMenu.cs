using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Game.GameFeatures.FightingAnEnemyMenus;
using RPGTextuel.Game.GameFeatures.RandomEvents;
using RPGTextuel.Game.GameUtilsNamespace;

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

            // Pour chaque ennemi dans la liste
            foreach (Enemy enemy in ennemies)
            {
                // 🔹 Déclenche un événement aléatoire avant le combat sauf pour le premier ennemi
                if (fightNumber > 0)
                {
                    RandomEventsInGame.TriggerRandomEventWithIntro(
                        player,
                        "Un événement survient avant votre prochain combat..."
                    );
                    GameUtils.WaitForUser();
                }

                // On affiche un message indiquant qu'on passe au combat suivant.
                MainMenuUtils.ShowEnemyIntroduction(enemy);

                // On délègue la gestion du menu principal à une méthode dédiée
                Boolean wantsToQuit = FightingAnEnemyMenu.HandleMainMenu(player, enemy);

                // Si le joueur quitte, on arrête la partie
                if (wantsToQuit)
                {
                    CloseGame.CloseTheGame();
                    return true;
                }

                // Si le joueur meurt, on arrête la partie
                if (!player.IsAlive)
                {
                    Console.WriteLine("Vous êtes mort. Fin de la partie.");
                    return true;
                }

                // Après chaque combat, on augmente le compteur de 1.
                fightNumber++;
            }
            return false;
        }
    }
}