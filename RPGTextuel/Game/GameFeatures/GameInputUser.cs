namespace RPGTextuel.Game.GameFeatures
{
    // Cette regroupe les méthodes liées aux demandes envers l'utilisateur.
    public class GameInputUser
    {
        // Cette méthode retourne le choix de l'utilisateur parmi un menu.
        public static int AskMenuChoice(List<string> options, string? title = null)
        {
            // On affiche la liste des possibilités
            GameDisplay.ShowOptionsList(options, title);

            while (true)
            {
                // On récupère la réponse de l'utilisateur.
                Console.Write("\nFaites votre choix : ");
                string? input = Console.ReadLine();

                // On analyse la réponse de l'utilisateur
                if (int.TryParse(input, out int choice) &&
                        choice >= 1 && choice <= options.Count)
                {
                    return choice;
                }

                // Si l'entrée n'est pas valide, on affiche un message.
                Console.WriteLine("Entrée invalide.");
            }
        }
    }
}