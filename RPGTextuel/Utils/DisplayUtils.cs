using RPGTextuel.Config;

namespace RPGTextuel.Utils
{
    // Cette classe fournit des méthodes utilitaires pour l'affichage
    public class DisplayUtils
    {
        // Cette méthode permet d'afficher un texte dans une couleur donnée
        public static void WriteLineInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = GameConfig.defaultColor;
        }
    }
}