using RPGTextuel.Core;
using RPGTextuel.Game.GameFeatures;

namespace RPGTextuel.Game
{
    // Cette classe s'occupe de gérer la boucle de jeu.
    public static class Game
    {
        // Cette méthode a pour but de lancer la partie
        public static void StartGame()
        {
            // On initialise la partie
            Player joueur = InitGame();
        }

        // Cette méthode permet d'initialiser la partie.
        // Elle affiche les messages d'accueils, demande le nom du joueur et l'instancie.
        // Elle retourne le joueur ainsi crée de type Player.
        private static Player InitGame()
        {
            // On affiche le message d'accueil
            GameDisplay.ShowWelcomeMessage();

            // On récupère le nom du joueur
            string name = GamePlayerName.AskAndVerifyPlayerName();

            // On crée l'instance de type joueur
            Player joueur = CreatePlayer.CreateAPlayer(name);

            // On affiche le dexième message d'accueil
            GameDisplay.ShowWelcomeMessage2(name);

            return joueur;
        }
    }
}