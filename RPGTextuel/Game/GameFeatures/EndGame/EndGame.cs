using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Utils;

namespace RPGTextuel.Game.GameFeatures.EndGame
{
    // Cette classe s'occupe de gérer la fin de partie
    public static class EndGame
    {
        // Cette méthode gère l'affichage en cas de victoire du joueur.
        public static void VictoryMessage()
        {
            Console.Clear();
            DisplayUtils.WriteLineInColor("🎉 Félicitations ! Vous avez vaincu tous les ennemis !", ConsoleColor.DarkGreen);
            GameUtils.WaitForUser(color: ConsoleColor.DarkGreen);
        }
    }
}