namespace RPGTextuel.Game.GameFeatures
{
    // Cette regroupe les méthodes liées aux demandes envers l'utilisateur.
    public class GameInputUser
    {
        // Cette méthode retourne le choix de l'utilisateur parmi un menu.
        public static int AskMenuChoice(List<string> options, string? title = null)
        {
            while (true)
            {
                // On affiche la liste des possibilités
                GameDisplay.ShowOptionsList(options, title);

                // On récupère la réponse de l'utilisateur.
                Console.Write("\nFaites votre choix : ");
                string? input = Console.ReadLine();
            }
        }
    }
}