using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameFeatures.InitPlayer;
using RPGTextuel.Game.GameFeatures.MainMenu;

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

            // On lance ouvre le menu principal et, on lance la boucle de jeu.
            // GameMainMenu.HandleMainMenu(player);
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
    }
}