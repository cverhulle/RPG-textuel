namespace RPGTextuel.Config
{
    // Cette classe s'occupe de la gestion des statistiques par défaut
    public static class GameStatConfig
    {
        // Coup critique 
        // Chance de coup critique par défaut
        public const double criticalHitByDefault = 0.05;

        // Chance de coup critique légérement augmenté
        public const double criticalHitAugmented = criticalHitByDefault + 0.1;

        // Chance de coup critique pour le joueur
        public const double criticalHitPlayer = 0.15;

        // Multiplicateur pour des dégats en coup critique
        public const double criticalMultiplicator = 1.4;
    }
}