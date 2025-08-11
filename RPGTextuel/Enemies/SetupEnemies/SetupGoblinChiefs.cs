using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.List;

namespace RPGTextuel.SetupEnemies
{
    // Cette classe permet de créer les ennemis de type chef gobelin que l'on affrontera
    public static class SetupGoblinChiefs
    {
        // Créeons la liste des ennemis de type "GoblinChief"
        public static List<GoblinChief> GoblinChiefs = new List<GoblinChief>
        {
            new GoblinChief("Zonva", 60, 12, 60),
            new GoblinChief("Grimlok", 65, 11, 65)
        };

        // Cette méthode permet de choisir aléatoirement un élement de la liste des GoblinChiefs.
        public static GoblinChief GetRandomGoblinChief()
        {
            return GoblinChiefs.PickRandom();
        }
    }
}