using RPGTextuel.Enemies.Class;

namespace RPGTextuel.Extensions
{   
    // Cette classe étend la classe Enemy
    public static class EnemyExtensions
    {   
        // Cette émthode permet d'afficher les stats d'un ennemi.
        public static void PrintStats(this Enemy enemy)
        {
            Console.WriteLine($"👽 {enemy.Name} - PV : {enemy.Health}/{enemy.MaxHealth}, Force : {enemy.Strength}");
        }

        // Cette méthode permet à un ennemi de pousser un cri.
        public static void Roar(this Enemy enemy)
        {
            Console.WriteLine($"{enemy.Name} pousse un cri féroce !");
        }
    }
}