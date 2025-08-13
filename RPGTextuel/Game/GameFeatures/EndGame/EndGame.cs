using RPGTextuel.Core;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Utils;

namespace RPGTextuel.Game.GameFeatures.EndGame
{
    // Cette classe s'occupe de gérer la fin de partie
    public static class EndGame
    {
        // Cette méthode est appelée pour fermer le jeu.
        public static void CloseGame()
        {
            Console.WriteLine("À bientôt !");
        }

        // Méthode utilitaire permettant de savoir si l'on doit arreter la partie.
        // On retourne True si c'est le cas et, false sinon.
        public static bool ShouldEndGame(bool wantsToQuit, Player player)
        {
            if (wantsToQuit)
            {
                CloseGame();
                return true;
            }

            if (!player.IsAlive)
            {
                Console.WriteLine("Vous êtes mort. Fin de la partie.");
                return true;
            }
            return false;
        }

        // Cette méthode gère l'affichage en cas de victoire du joueur.
        public static void VictoryMessage()
        {
            Console.Clear();
            DisplayUtils.WriteLineInColor("🎉 Félicitations ! Vous avez vaincu tous les ennemis !", ConsoleColor.DarkGreen);
            GameUtils.WaitForUser(color: ConsoleColor.DarkGreen);
        }
    }
}