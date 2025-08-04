using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.List;

namespace RPGTextuel.SetupEnemies
{
    // Cette classe permet de créer les ennemis de type gobelins que l'on affrontera
    public static class SetupGoblins
    {
        // Créeons la liste des ennemis de type "Goblin"
        public static List<Goblin> Goblins = new List<Goblin>
        {
            new Goblin("Snot", 36, 8, 36),
            new Goblin("Pak", 40, 7, 40),
            new Goblin("Tark", 45, 6, 45)
        };

        // Cette méthode permet de choisir aléatoirement un élement de la liste des Goblins.
        public static Goblin GetRandomGoblin()
        {
            return Goblins.PickRandom();
        }
    }
}