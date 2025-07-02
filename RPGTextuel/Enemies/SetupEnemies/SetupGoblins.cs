using RPGTextuel.Enemies.Class;

namespace RPGTextuel.SetupEnemies
{
    // Cette classe permet de créer les ennemies que l'on affrontera
    public static class SetupGoblins
    {
        // Créeons la liste des ennemies de type "Goblin"
        public static List<Goblin> Goblins = new List<Goblin>
        {
            new Goblin("Snot", 36, 8, 40),
            new Goblin("Pak", 40, 7, 40),
            new Goblin("Tark", 45, 6, 45)
        };
    }
}