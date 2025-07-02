namespace RPGTextuel
{
    // Cette classe permet de créer les ennemis de type "GoblinMinion".
    public static class SetupGoblinMinions
    {
        // Créeons la liste des ennemies de type "GoblinMinion"
        public static List<GoblinMinion> GoblinMinions = new List<GoblinMinion>
        {
            new GoblinMinion("Virk", 20, 4, 20),
            new GoblinMinion("Nak", 30, 2, 25),
            new GoblinMinion("Vrag", 25, 3, 25)
        };
    }
}