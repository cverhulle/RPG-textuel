using RPGTextuel.Core;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Utils;

namespace RPGTextuel.Game.GameFeatures.EndGameNamespace
{
    // Cette classe s'occupe de gérer la fin de partie
    public static class EndGame
    {
        // Cette méthode est appelée lorsque le joueur décide de fermer le jeu.
        public static void PlayerCloseGame()
        {
            Console.WriteLine("À bientôt !");
        }

        // Cette méthode est appelée lorsque le joueur meurt
        public static void DeathMessage()
        {
            Console.Clear();
            DisplayUtils.WriteLineInColor("Vous êtes mort. Fin de la partie.", ConsoleColor.DarkRed);
            GameUtils.WaitForUser(color: ConsoleColor.DarkRed);
        }

        // Cette méthode retourne l'état du joueur sous forme de booléen.
        public static bool isPlayerDead(Player player)
        {
            if (!player.IsAlive)
            {
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