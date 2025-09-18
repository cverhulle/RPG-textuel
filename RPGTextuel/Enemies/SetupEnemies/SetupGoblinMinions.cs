using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.List;

namespace RPGTextuel.SetupEnemies
{
    /// <summary>
    /// Contient la configuration et la génération aléatoire
    /// des ennemis de type GoblinMinion.
    /// </summary>
    public static class SetupGoblinMinions
    {
        // Liste privée des gobelins de type "GoblinMinion"
        public static List<GoblinMinion> GoblinMinions = new List<GoblinMinion>
        {
            new GoblinMinion("Virk", 20, 4, 20),
            new GoblinMinion("Nak", 25, 2, 25),
            new GoblinMinion("Vrag", 25, 3, 25)
        };

        /// <summary>
        /// Retourne un gobelin de type "GoblinMinion" aléatoire cloné à partir de la liste prédéfinie.
        /// </summary>
        public static GoblinMinion GetRandomGoblinMinion()
        {
            var template = GoblinMinions.PickRandom();
            return (GoblinMinion) template.Clone(); 
        }
    }
}