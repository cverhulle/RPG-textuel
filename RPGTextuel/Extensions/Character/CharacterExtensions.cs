using RPGTextuel.Core.Characters;
using RPGTextuel.Config;

namespace RPGTextuel.Extensions.Characters
{
    /// <summary>
    /// Fournit des méthodes d'extension pour enrichir la classe <see cref="Character"/>.
    /// </summary>
    public static class CharacterExtensions
    {
        // Cette méthode permet d'afficher la barre de vie d'un character.
        public static void PrintHealthBar(this Character character)
        {
            // On appelle la méthode pour construire la barre de vie.
            string bar = BuildHealthBar(
                character,
                GameConfig.HealthBarLength,
                GameConfig.FilledHeartSymbol,
                GameConfig.EmptyHeartSymbol
            );

            // Affichage de la barre de vie.
            Console.WriteLine($"{character.Name} : [{bar}] {character.Health}/{character.MaxHealth} PV");
        }

        // Cette méthode s'occupe de construire la barre de vie.
        private static string BuildHealthBar(Character character, int total, string filledSymbol, string emptySymbol)
        {
            // On récupère le nombre de coeurs à remplir et à laisser vide.
            var (filled, empty) = GetFilledAndEmptyHeart(character, total);

            // Construction de la barre de vie.
            string bar = new string(' ', 0);

            for (int i = 0; i < filled; i++)
                bar += filledSymbol;
            for (int i = 0; i < empty; i++)
                bar += emptySymbol;

            return bar;
        }

        // Cette méthode permet de calculer le nombre de coeurs restants.
        // Elle retourne le nombre de coeurs à remplir dans la barre et le nombre de coeurs vides.
        private static (int, int) GetFilledAndEmptyHeart(Character character, int total)
        {
            // On gère la division par 0 (cas où maxHealth = 0).
            if (character.MaxHealth <= 0) return (0, total);

            // On calcule le ratio entre la vie restante sur la vie total
            double ratio = (double)character.Health / character.MaxHealth;
            ratio = Math.Clamp(ratio, 0, 1); // On fait en sorte que ratio reste entre 0 et 1.

            // On calcule le nombre de coeurs de vie on doit afficher.
            // Au minimum, un coeur est rouge si le perso n'est pas mort.
            int filled = character.Health > 0 
                ? Math.Max(1, (int)(ratio * total)) 
                : 0;

            // On calcule le nombre de coeurs vides à afficher
            int empty = total - filled;

            return (filled, empty);
        }
    }
}