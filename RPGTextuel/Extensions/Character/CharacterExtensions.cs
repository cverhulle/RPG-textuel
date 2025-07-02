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

            // On calcule le ratio entre la vie restante sur la vie total
            double ratio = (double)character.Health / character.MaxHealth;

            // On calcule le nombre de coeurs de vie on doit afficher.
            int filled = (int)(ratio * total);

            // On calcule le nombre de coeurs vides à afficher
            int empty = total - filled;

            // On choisit les symboles pour la barre.
            string filledSymbol = "🧡 ";
            string emptySymbol = "🤍 ";

            // Construction de la barre de vie.
            string bar = new string(' ', 0);

            for (int i = 0; i < filled; i++)
                bar += filledSymbol;
            for (int i = 0; i < empty; i++)
                bar += emptySymbol;

            Console.WriteLine($"{character.Name} : [{bar}] {character.Health}/{character.MaxHealth} PV");
        }
    }
}