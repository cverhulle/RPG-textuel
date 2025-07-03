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
            string playerName = InitGame();

        }

        // Cette méthode permet d'initialiser la partie.
        // Elle affiche le message d'accueil et retourne le nom du joueur.
        private static string InitGame()
        {
            // On affiche le message d'accueil
            GameDisplay.ShowWelcomeMessage();

            // On récupère le nom du joueur
            string name = GamePlayerName.AskAndVerifyPlayerName();

            // On affiche le dexième message d'accueil
            GameDisplay.ShowWelcomeMessage2(name);

            return name;
        }

    }
}