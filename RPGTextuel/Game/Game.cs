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
            Console.Write("🐱‍🏍 Entrez le nom de votre héros : ");
            return Console.ReadLine()?.Trim() ?? "";
        }

        // Cette méthode récupère le nom du héros du joueur
        private static string AskAndVerifyPlayerName()
        {
            // On initialise une variable name de type string.
            string name;

            // On initialise la variable pour savoir si le nom est valide.
            Boolean valid = false;

            do
            {
                // On demande le nom du joueur à l'utilisateur 
                name = AskPlayerName();

                // On analyse si le nom est correct.
                valid = HandlePlayerName(name);

            } while (valid);

            return name;
        }

        // Cette méthode prend un nom en argument et vérifie qu'il est valide pour un joueur.
        private static Boolean HandlePlayerName(string name)
        {
            // Si le nom est vide ou null, on affiche un message et, on repose la question.
            if (GameUtils.IsNameNullOrWhiteSpace(name))
            {
                Console.WriteLine("❌ Le nom ne peut pas être vide. Réessayez.\n");
                return false;
            }
            else if (GameUtils.IsNameTooLong(name))
            {
                Console.WriteLine($"❌ Le nom ne peut pas dépasser {GameConfig.MaxNameLength} Réessayez.\n");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}