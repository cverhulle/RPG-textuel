namespace RPGTextuel
{
    // Cette classe permet de créer les ennemies que l'on affrontera
    public static class SetupEnemies
    {
        // Créeons la liste des ennemies de type "GoblinMinion"
        public static List<GoblinMinion> GoblinMinions = new List<GoblinMinion>
        {
            new GoblinMinion("Virk", 20, 4, 20),
            new GoblinMinion("Nak", 30, 2, 25),
            new GoblinMinion("Vrag", 25, 3, 25)
        };

        // Créeons la liste des ennemies de type "Goblin"
        public static List<Goblin> Goblins = new List<Goblin>
        {
            new Goblin("Snot", 36, 8, 40),
            new Goblin("Pak", 40, 7, 40),
            new Goblin("Tark", 45, 6, 45)
        };

        // Créeons la liste des ennemies de type "GoblinChief"
        public static List<GoblinChief> GoblinChiefs = new List<GoblinChief>
        {
            new GoblinChief("Zonva", 60, 15, 60),
            new GoblinChief("Grimlok", 65, 13, 65)
        };

        // Méthode pour récupérer un gobelin aléatoire
        public static Goblin GetRandomGoblin()
        {
            var rng = new System.Random();
            return Goblins[rng.Next(Goblins.Count)];
        }

        // Méthode pour récupérer un Petit Gobelin aléatoire
        public static GoblinMinion GetRandomGoblinMinion()
        {
            var rng = new System.Random();
            return GoblinMinions[rng.Next(GoblinMinions.Count)];
        }

        // Méthode pour récupérer un Petit Gobelin aléatoire
        public static GoblinChief GetRandomGoblinChief()
        {
            var rng = new System.Random();
            return GoblinChiefs[rng.Next(GoblinChiefs.Count)];
        }
    }
}