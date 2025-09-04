using RPGTextuel.Core;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Utils;

namespace RPGTextuel.Game.GameFeatures.EndGameNamespace
{
    // Cette classe s'occupe de gérer la fin de partie
    public static class EndGame
    {
        // Cette méthode est appelée lorsque le joueur décide de fermer le jeu.
        private static void PlayerCloseGame()
        {
            Console.WriteLine("À bientôt !");
        }

        // Cette méthode est appelée lorsque le joueur meurt
        private static void DeathMessage()
        {
            Console.Clear();
            DisplayUtils.WriteLineInColor("Vous êtes mort. Fin de la partie.", ConsoleColor.DarkRed);
            GameUtils.WaitForUser(color: ConsoleColor.DarkRed);
        }

        // Cette méthode permet de gérer la mort du joueur
        // Elle retourne l'état du joueur sous forme de booléen.
        public static bool isPlayerDead(Player player)
        {
            if (!player.IsAlive)
            {
                DeathMessage();
                return true;
            }
            return false;
        }

        /*
        // Méthode utilitaire permettant de savoir si l'on doit arreter la partie.
        // On retourne True si c'est le cas et, false sinon.
        public static bool ShouldEndGame(bool wantsToQuit, Player player)
        {
            if (wantsToQuit)
            {
                PlayerCloseGame();
                return true;
            }

            return isPlayerDead(player);
        }
        */

        // Cette méthode gère l'affichage en cas de victoire du joueur.
        public static void VictoryMessage()
        {
            Console.Clear();
            DisplayUtils.WriteLineInColor("🎉 Félicitations ! Vous avez vaincu tous les ennemis !", ConsoleColor.DarkGreen);
            GameUtils.WaitForUser(color: ConsoleColor.DarkGreen);
        }
    }
}