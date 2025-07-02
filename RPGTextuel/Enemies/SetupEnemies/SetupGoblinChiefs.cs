using RPGTextuel.Enemies.Class;

namespace RPGTextuel.SetupEnemies
{
    // Cette classe permet de créer les ennemies que l'on affrontera
    public static class SetupGoblinChiefs
    {
        // Créeons la liste des ennemies de type "GoblinChief"
        public static List<GoblinChief> GoblinChiefs = new List<GoblinChief>
        {
            new GoblinChief("Zonva", 60, 15, 60),
            new GoblinChief("Grimlok", 65, 13, 65)
        };
    }
}