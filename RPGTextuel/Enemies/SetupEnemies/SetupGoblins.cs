using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.List;

namespace RPGTextuel.SetupEnemies
{
    /// <summary>
    /// Contient la configuration et la génération aléatoire
    /// des ennemis de type Goblin.
    /// </summary>
    public static class SetupGoblins
    {
        // Liste privée des gobelins.
        public static List<Goblin> Goblins = new List<Goblin>
        {
            new Goblin("Snot", 36, 8, 36),
            new Goblin("Pak", 40, 7, 40),
            new Goblin("Tark", 45, 6, 45)
        };

        /// <summary>
        /// Retourne un gobelin aléatoire cloné à partir de la liste prédéfinie.
        /// </summary>
        public static Goblin GetRandomGoblin()
        {
            var template = Goblins.PickRandom();
            return (Goblin) template.Clone(); 
        }
    }
}