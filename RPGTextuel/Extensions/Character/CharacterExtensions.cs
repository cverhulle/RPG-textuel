using RPGTextuel.Core.Characters;

namespace RPGTextuel.Extensions.Characters
{
    // Cette classe permet de créer des extensions de la classe Character.
    public static class CharacterExtensions
    {
        // Cette méthode permet d'afficher la barre de vie d'un character.
        public static void PrintHealthBar(this Character character)
        {
            // On initialise la taille de la barre de vie à 20 caractères.
            int total = 10;

            // On choisit les symboles pour la barre.
            string filledSymbol = "🧡 ";
            string emptySymbol = "🤍 ";

            // On appelle la méthode pour construire la barre de vie.
            string bar = character.BuildHealthBar(total, filledSymbol, emptySymbol);

            // Affichage de la barre de vie.
            Console.WriteLine($"{character.Name} : [{bar}] {character.Health}/{character.MaxHealth} PV");
        }

        // Cette méthode s'occupe de construire la barre de vie.
        public static string BuildHealthBar(this Character character, int total, string filledSymbol, string emptySymbol)
        {

            // On calcule le ratio entre la vie restante sur la vie total
            double ratio = (double)character.Health / character.MaxHealth;

            // On calcule le nombre de coeurs de vie on doit afficher.
            int filled = (int)(ratio * total);

            // On calcule le nombre de coeurs vides à afficher
            int empty = total - filled;

            // Construction de la barre de vie.
            string bar = new string(' ', 0);

            for (int i = 0; i < filled; i++)
                bar += filledSymbol;
            for (int i = 0; i < empty; i++)
                bar += emptySymbol;

            return bar;
        }

        // Cette méthode permet de calculer le nombre de coeurs restants
        public static (int, int) GetFilledAndEmptyHeart(this Character character, int total)
        {
            // On calcule le ratio entre la vie restante sur la vie total
            double ratio = (double)character.Health / character.MaxHealth;

            // On calcule le nombre de coeurs de vie on doit afficher.
            int filled = (int)(ratio * total);

            // On calcule le nombre de coeurs vides à afficher
            int empty = total - filled;

            return (filled, empty);
        }
    }
}