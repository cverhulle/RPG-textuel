using RPGTextuel.Config;

namespace RPGTextuel.Game
{
    // Cette classe s'occupe de gérer la boucle de jeu.
    public static class Game
    {
        // Cette méthode demande à l'utilisateur le nom pour son joueur
        private static string AskPlayerName()
        {
            // On demande le nom à l'utilisateur.
            Console.Write("Entrez le nom de votre héros : ");
            return Console.ReadLine()?.Trim() ?? "";
        }

        // Cette méthode récupère le nom du héros du joueur
        public static string AskAndVerifyPlayerName()
        {
            // On initialise une variable name de type string.
            string name;

            // On initialise la variable pour savoir si le nom est valide.
            Boolean valid = true;

            do
            {
                // On demande le nom du joueur à l'utilisateur 
                name = AskPlayerName();

                // On analyse si le nom est correct.
                valid = VerifyPlayerName(name);

            } while (valid);

            return name;
        }

        // Cette méthode prend un nom en argument et vérifie qu'il est valide pour un joueur.
        private static Boolean VerifyPlayerName(string name)
        {
            // Si le nom est vide ou null, on affiche un message et, on repose la question.
            if (GameUtils.IsNameNullOrWhiteSpace(name))
            {
                Console.WriteLine("❌ Le nom ne peut pas être vide. Réessayez.\n");
                return true;
            }
            else if (GameUtils.IsNameTooLong(name))
            {
                Console.WriteLine($"❌ Le nom ne peut pas dépasser {GameConfig.MaxNameLength} caractères. Réessayez.\n");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}