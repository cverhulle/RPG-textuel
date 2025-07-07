using RPGTextuel.Core;
using RPGTextuel.Core.Characters;
using RPGTextuel.Extensions.Characters;

namespace RPGTextuel.Game.GameUtilsNamespace
{
    // Cette classe s'occupe de gérer l'affichage pour le jeu.
    public static class GameDisplay
    {
        // Cette méthode affiche l'inventaire du joueur et met le jeu en attente.
        public static void PrintInventory(Player player)
        {
            player.Inventory.DisplayInventory();
            GameUtils.WaitForUser();
        }

        // Cette méthode affiche les stats d'un personnage et met le jeu en attente.
        public static void PrintStats(Character character)
        {
            character.PrintStats();
            GameUtils.WaitForUser();
        }

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
            }
        }
    }       
}