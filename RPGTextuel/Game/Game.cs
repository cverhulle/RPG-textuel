
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

            do
            {
                Console.Write("🐱‍🏍 Entrez le nom de votre héros : ");
                name = Console.ReadLine()?.Trim() ?? "";

                // Si le nom est vide ou null, on affiche un message et, on repose la question.
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("❌ Le nom ne peut pas être vide. Réessayez.\n");
                }

            } while (string.IsNullOrWhiteSpace(name));

            return name;
        }
    }
}