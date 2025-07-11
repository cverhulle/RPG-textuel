using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Enemies;
using RPGTextuel.Game.GameFeatures.FightingAnEnemyMenus;
using RPGTextuel.Game.GameFeatures.InitPlayer;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game
{
    // Cette classe s'occupe de gérer la boucle de jeu.
    public static class Game
    {
        // Cette méthode a pour but de lancer la partie
        public static void StartGame()
        {
            // On initialise la partie
            (Player player, List<Enemy> ennemies) = InitGame();

            // Si tous les ennemis sont vaincus
            VictoryMessage();
        }

        // Cette méthode permet d'initialiser la partie.
        // Elle affiche les messages d'accueils, demande le nom du joueur et l'instancie.
        // Elle s'occupe également de créer la liste des ennemis à affronter pendant cette partie.
        // Elle retourne le joueur ainsi crée de type Player.
        private static (Player player, List<Enemy> ennemies) InitGame()
        {
            // On affiche le message d'accueil
            InitWelcomeMessage.ShowWelcomeMessage();

            // On récupère le nom du joueur
            string name = InitPlayerName.AskAndVerifyPlayerName();

            // On crée l'instance de type joueur
            Player player = InitPlayerCreation.CreateAPlayer(name);

            // On crée la liste des ennemis pendant cette partie
            List<Enemy> ennemies = InitEnnemiesToFight.GetRandomGoblinSet();

            // On affiche le dexième message d'accueil
            InitWelcomeMessage.ShowWelcomeMessage2(name);

            return (player, ennemies);
        }

        // Cette méthode lance la boucle de jeu.
        private static void LaunchGame(Player player, List<Enemy> ennemies)
        {
            // Pour chaque ennemi dans la liste
            foreach (Enemy enemy in ennemies)
            {
                // On affiche un message indiquant qu'on passe au combat suivant.
                Console.Clear();
                Console.WriteLine($"Un nouvel ennemi approche !");
                enemy.PrintStats();
                GameUtils.WaitForUser();

                // On délègue la gestion du menu principal à une méthode dédiée
                Boolean wantsToQuit = FightingAnEnemyMenu.HandleMainMenu(player, enemy);

                // Si le joueur quite, on arrête la partie
                if (wantsToQuit)
                {
                    CloseGame.CloseTheGame();
                    return;
                }

                // Si le joueur meurt, on arrête la partie
                if (!player.IsAlive)
                {
                    Console.WriteLine("Le joueur est mort. Fin de la partie.");
                    return;
                }
            }
        }

        // Cette méthode gère l'affichage en cas de victoire du joueur.
        private static void VictoryMessage()
        {
            Console.Clear();
            Console.WriteLine("🎉 Félicitations ! Vous avez vaincu tous les ennemis !");
            GameUtils.WaitForUser();
        }

    }
}