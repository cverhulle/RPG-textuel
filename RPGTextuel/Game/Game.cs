using RPGTextuel.Config;

namespace RPGTextuel.Game
{
    // Cette classe s'occupe de gérer la boucle de jeu.
    public static class Game
    {

        // Cette méthode récupère le nom du héros du joueur
        private static string GetPlayerName()
        {
            // On initialise une variable name de type string.
            string name;

            // On itniatialise la variable pour savoir si le nom est valide.
            Boolean valid = false;

            do
            {
                Console.Write("🐱‍🏍 Entrez le nom de votre héros : ");
                name = Console.ReadLine()?.Trim() ?? "";

                // Si le nom est vide ou null, on affiche un message et, on repose la question.
                if (GameUtils.IsNameNullOrWhiteSpace(name))
                {
                    Console.WriteLine("❌ Le nom ne peut pas être vide. Réessayez.\n");
                }
                else if (GameUtils.IsNameTooLong(name))
                {
                    Console.WriteLine($"❌ Le nom ne peut pas dépasser {GameConfig.MaxNameLength} Réessayez.\n");
                }
                else
                {
                    valid = true;
                }

            } while (valid);

            return name;
        }
    }
}