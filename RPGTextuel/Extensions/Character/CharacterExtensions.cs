using RPGTextuel.Core.Characters;

namespace RPGTextuel.Extensions
{   
    // Cette classe permet de créer des extensions de la classe Character.
    public static class CharacterExtensions
    {
        // Cette méthode permet d'afficher la barre de vie d'un character.
        public static void PrintHealthBar(this Character character)
        {
            int total = 20;
            double ratio = (double)character.Health / character.MaxHealth;
            int filled = (int)(ratio * total);
            string bar = new string('❤', filled).PadRight(total);

            Console.WriteLine($"{character.Name} : [{bar}] {character.Health}/{character.MaxHealth} PV");
        }
    }
}