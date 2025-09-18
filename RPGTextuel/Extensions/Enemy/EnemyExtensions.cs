using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Characters;

namespace RPGTextuel.Extensions.Enemies
{
    /// <summary>
    /// Fournit des méthodes d'extension pour enrichir la classe <see cref="Enemy"/>.
    /// </summary>
    public static class EnemyExtensions
    {
        /// <summary>
        /// Fait pousser un cri féroce à l’ennemi dans la console.
        /// </summary>
        /// <param name="enemy">L'ennemi qui rugit.</param>
        public static void Roar(this Enemy enemy)
        {
            Console.WriteLine($"{enemy.Name} pousse un cri féroce !");
        }
        
        /// <summary>
        /// Affiche dans la console toutes les statistiques de l’ennemi,
        /// y compris sa barre de vie, sa force et son taux de critique.
        /// </summary>
        /// <param name="enemy">L'ennemi dont les statistiques doivent être affichées.</param>
        public static void PrintStats(this Enemy enemy)
        {
            string title = $" STATISTIQUES DE {enemy.Name.ToUpper()} ";
            string border = new string('=', title.Length + 12);

            Console.WriteLine($"===== {title.ToUpper()} =====");
            Console.WriteLine($"Nom        : {enemy.Name}");
            Console.Write("PV         : ");
            enemy.PrintHealthBar();
            Console.WriteLine($"Force      : {enemy.Strength}");
            Console.WriteLine($"Critique   : {enemy.CriticalHitChance * 100:0.##}%");
            Console.WriteLine($"Type       : {enemy.DisplayType}");
            Console.WriteLine(border);
        }
    }
}