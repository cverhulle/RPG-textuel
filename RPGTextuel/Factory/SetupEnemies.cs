namespace RPGTextuel
{
    // Cette classe permet de créer les ennemies que l'on affrontera
    public static class SetupEnemies
    {
        // Créeons la liste des ennemies de type "GoblinMinion"
        public static List<GoblinMinion> GoblinMinions = new List<GoblinMinion>
        {
            new GoblinMinion("Jack", 20, 5, 20),
            new GoblinMinion("Paul", 30, 2, 25),
            new GoblinMinion("Leo", 25, 4, 25)
        };
    }
}