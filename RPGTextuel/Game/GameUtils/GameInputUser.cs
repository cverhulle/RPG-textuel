using RPGTextuel.Config;
using RPGTextuel.Utils;

namespace RPGTextuel.Game.GameUtilsNamespace
{
    // Cette regroupe les méthodes liées aux demandes envers l'utilisateur.
    public class GameInputUser
    {
        // Cette méthode affiche une question à l'utilisateur et retourne sa réponse.
        public static string AskUserInput(string prompt, ConsoleColor color = GameConfig.defaultColor)
        {
            // On affiche la question à l'utilisateur.
            DisplayUtils.WriteLineInColor(prompt, color);

            // On retourne la réponse et, par défaut un message vide.
            return Console.ReadLine() ?? string.Empty;
        }

        // Cette méthode retourne le choix de l'utilisateur parmi un menu.
        public static int AskMenuChoice(List<string> options, string? title = null, ConsoleColor color = GameConfig.defaultColor)
        {
            // On affiche la liste des possibilités
            GameDisplay.ShowOptionsList(options, title, color);

            while (true)
            {
                // On récupère la réponse de l'utilisateur.
                string input = AskUserInput("\nFaites votre choix :", color);

                // On analyse la réponse de l'utilisateur
                if (GameUtils.IsValidMenuChoice(input, options.Count, out int choice))
                {
                    return choice;
                }

                // Si l'entrée n'est pas valide, on affiche un message.
                DisplayUtils.WriteLineInColor("Entrée invalide.", color);
            }
        }
    }
}