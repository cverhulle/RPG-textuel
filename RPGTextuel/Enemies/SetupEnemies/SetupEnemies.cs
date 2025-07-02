namespace RPGTextuel
{
    // Cette classe permet de créer les ennemies que l'on affrontera
    public static class SetupEnemies
    {
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
    }
}