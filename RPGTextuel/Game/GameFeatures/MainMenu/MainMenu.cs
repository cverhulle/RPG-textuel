using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Game.GameFeatures.FightingAnEnemyMenus;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.RandomEvent.Factory;

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
            // Pour chaque ennemi dans la liste
            foreach (Enemy enemy in ennemies)
            {
                // On sauvegarde le nombre d'ennemis que l'on combat.
                int fightNumber = 0;

                // 🔹 Déclenche un événement aléatoire avant le combat sauf pour le premier ennemi
                if (fightNumber > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Un événement survient avant votre prochain combat...");
                    var randomEvent = RandomEventFactory.GetRandomEvent();
                    Console.WriteLine($"\nÉvénement : {randomEvent.Name}");
                    Console.WriteLine($"{randomEvent.Description}\n");
                    randomEvent.Trigger(player);
                    GameUtils.WaitForUser();
                }

                // On affiche un message indiquant qu'on passe au combat suivant.
                Console.Clear();
                Console.WriteLine($"Un nouvel ennemi approche !");
                enemy.PrintStats();
                GameUtils.WaitForUser();

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