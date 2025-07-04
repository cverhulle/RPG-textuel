namespace RPGTextuel.Game.GameFeatures
{
    // Cette classe s'occupe de gérer l'affichage pour le jeu.
    public static class GameDisplay
    {
        // Cette méthode affiche permet d'afficher une liste d'options.
        // Elle prend en paramètre une liste de phrases à afficher et, éventuellement, un titre.
        public static void ShowOptionsList(List<string> options, string? title = null)
        {
            // Si options est vide ou null, on retourne une erreur.
            if (options == null || options.Count == 0)
            {
                throw new ArgumentException("Le menu ne peut pas être vide.");
            }

            // On affiche le titre si présent
            if (!string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine($"===== {title.ToUpper()} =====\n");
            }

            // On affiche la liste des options.
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            // On affiche une ligne décorative qui matche avec le titre.
            if (!string.IsNullOrWhiteSpace(title))
            {
                int backlineLength = $"===== {title} =====".Length;
                Console.WriteLine(new string('=', backlineLength));
                Console.WriteLine();
            }
        }        

        // Cette méthode affiche le message de début de jeu
        public static void ShowWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Bienvenue dans AventureRPG ✨");
            Console.WriteLine("Avant de commencer, donnez un nom à votre héros !");
            Console.WriteLine();
        }

        // Cette méthode se déclenche après le choix du nom du personnage, après initialisation du jeu
        public static void ShowWelcomeMessage2(string name)
        {
            Console.WriteLine();
            Console.WriteLine("Bienvenue " + name);
            Console.WriteLine("Vous allez devoir affronter trois ennemis redoutables !");
            Console.WriteLine("Choisissez une option dans le menu suivant :");
            Console.WriteLine();
        }
    }
}