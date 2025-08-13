using RPGTextuel.Core;
using RPGTextuel.Core.Characters;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Players;
using RPGTextuel.Extensions.Enemies;

namespace RPGTextuel.Game.GameUtilsNamespace
{
    // Cette classe s'occupe de gérer l'affichage pour le jeu.
    public static class GameDisplay
    {
        // Cette méthode est une méthode générique pour afficher une liste d'options.
        public static void PrintFramedList<T>(List<T> elements, Func<T, string> formatter, string? title = null, bool showCount = false)
        {
            // Si elements est vide ou null, on retourne une erreur.
            if (elements == null || elements.Count == 0)
            {
                Console.WriteLine("Aucun élément à afficher.");
                return;
            }

            // Construction du titre encadré
            if (!string.IsNullOrWhiteSpace(title))
            {
                string header = $"===== {title.ToUpper()} =====";
                Console.WriteLine(header);
            }

            // Affichage des éléments formatés
            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {formatter(elements[i])}");
            }

            // Ligne de fin si titre présent
            if (!string.IsNullOrWhiteSpace(title))
            {
                int underlineLength = $"===== {title} =====".Length;
                Console.WriteLine(new string('=', underlineLength));
            }

            // Affichage du compteur
            if (showCount)
            {
                Console.WriteLine($"\n{elements.Count} élément(s) au total.");
            }
        }

        // Cette méthode affiche l'inventaire du joueur et met le jeu en attente.
        public static void PrintInventory(Player player)
        {
            player.Inventory.DisplayInventory();
            GameUtils.WaitForUser();
        }

        // Cette méthode affiche les stats d'un personnage et met le jeu en attente.
        public static void PrintStats(Character character)
        {
            switch (character)
                {
                    case Player player:
                        player.PrintStats();
                        break;

                    case Enemy enemy:
                        enemy.PrintStats();
                        break;

                    default:
                        Console.WriteLine("Type de personnage inconnu.");
                        break;
                }

            GameUtils.WaitForUser();
        }

        // Cette méthode permet d'afficher un message et les stats d'un ennemi.
        public static void ShowEnemyStatsWithAMessage(Enemy enemy, string message, bool isBoss = false)
        {
            Console.Clear();

            // Si c'est un combat de boss, l'affichage passe en rouge.
            if (isBoss)
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(message);
            enemy.PrintStats();

            // On remet la couleur en noire dans tous les cas.
            Console.ResetColor();

            // On laisse à l'utilisateur le temps de lire et d'avancer au clic.
            GameUtils.WaitForUser();
        }

        // Cette méthode affiche permet d'afficher une liste d'options.
        // Elle prend en paramètre une liste de phrases à afficher et, éventuellement, un titre.
        public static void ShowOptionsList(List<string> options, string? title = null)
        {
            PrintFramedList(options, option => option, title);
        }
    }       
}