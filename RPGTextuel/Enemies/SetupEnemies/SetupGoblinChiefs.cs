using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.List;

namespace RPGTextuel.SetupEnemies
{
    /// <summary>
    /// Contient la configuration et la génération aléatoire
    /// des ennemis de type GoblinChief.
    /// </summary>
    public static class SetupGoblinChiefs
    {
        // Liste des chefs gobelins prédéfinis
        public static List<GoblinChief> GoblinChiefs = new List<GoblinChief>
        {
            new GoblinChief("Zonva", 60, 12, 60),
            new GoblinChief("Grimlok", 65, 10, 65),
            new GoblinChief("Brom", 45, 8, 45, 0.3)
        };

        /// <summary>
        /// Retourne un chef gobelin aléatoire cloné à partir de la liste prédéfinie.
        /// </summary>
        public static GoblinChief GetRandomGoblinChief()
        {
            var template = GoblinChiefs.PickRandom();
            return (GoblinChief) template.Clone(); 
        }
    }
}