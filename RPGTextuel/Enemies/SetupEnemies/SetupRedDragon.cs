using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.List;

namespace RPGTextuel.SetupEnemies
{
    /// <summary>
    /// Contient la configuration et la génération aléatoire
    /// des ennemis de type Dragon Rouge.
    /// </summary>
    public static class SetupRedDragons
    {
        // Liste privée des dragons rouges prédéfinis.
        public static List<RedDragon> RedDragons = new List<RedDragon>
        {
            new RedDragon("Spyro", 100, 15, 100),
            new RedDragon("Ignir", 70, 12, 70, 0.5),        // moins de PV mais beaucoup de critique
            new RedDragon("Alexstrasza", 150, 6, 150, 0),   // Beaucoup de PV, peu de dégats, 0% critique
        };

        /// <summary>
        /// Retourne un dragon rouge aléatoire cloné à partir de la liste prédéfinie.
        /// </summary>
        public static RedDragon GetRandomRedDragon()
        {
            var template = RedDragons.PickRandom();
            return (RedDragon) template.Clone(); 
        }
    }
}