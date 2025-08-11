using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.List;

namespace RPGTextuel.SetupEnemies
{
    // Cette classe permet de créer les ennemies de type Dragon Rouge que l'on affrontera
    public static class SetupRedDragons
    {
        // Créeons la liste des ennemies de type "Dragon Rouge"
        public static List<RedDragon> RedDragons = new List<RedDragon>
        {
            new RedDragon("Spyro", 100, 18, 100),
            new RedDragon("Ignir", 70, 15, 70, 0.5),   // moins de PV mais beaucoup de critique
        };

        // Cette méthode permet de choisir aléatoirement un élement de la liste des Dragons rouges.
        public static RedDragon GetRandomRedDragon()
        {
            return RedDragons.PickRandom();
        }
    }
}