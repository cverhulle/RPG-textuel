using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Characters;

namespace RPGTextuel.Extensions.Enemies
{
    // Cette classe étend la classe Enemy
    public static class EnemyExtensions
    {
        // Cette méthode permet à un ennemi de pousser un cri.
        public static void Roar(this Enemy enemy)
        {
            Console.WriteLine($"{enemy.Name} pousse un cri féroce !");
        }
        
        // Cette méthode permet d'afficher toutes les statistiques d'un ennemi.
        public static void PrintStats(this Enemy enemy)
        {
            string title = $" STATISTIQUES DE {enemy.Name.ToUpper()} ";
            string border = new string('=', title.Length + 12);

            Console.WriteLine($"===== {title.ToUpper()} =====");
            Console.WriteLine($"Nom        : {enemy.Name}");
            Console.Write("PV         : ");
            enemy.PrintHealthBar();
            Console.WriteLine($"Force      : {enemy.Strength}");
            Console.WriteLine($"Type      : {enemy.GetType}");
            Console.WriteLine(border);
        }
    }
}