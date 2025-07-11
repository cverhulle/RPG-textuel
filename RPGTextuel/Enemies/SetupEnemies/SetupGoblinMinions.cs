using RPGTextuel.Enemies.Class;

namespace RPGTextuel.SetupEnemies
{
    // Cette classe permet de créer les ennemis de type "GoblinMinion".
    public static class SetupGoblinMinions
    {
        // Créeons la liste des ennemies de type "GoblinMinion"
        public static List<GoblinMinion> GoblinMinions = new List<GoblinMinion>
        {
            new GoblinMinion("Virk", 20, 4, 20),
            new GoblinMinion("Nak", 25, 2, 25),
            new GoblinMinion("Vrag", 25, 3, 25)
        };

        // Cette méthode permet de choisir aléatoirement un élement de la liste des GoblinMinions.
        public static GoblinMinion GetRandomGoblinMinion()
        {
            return GoblinMinions.PickRandom();
        }
    }
}