namespace RPGTextuel.Config
{
    /// <summary>
    /// Contient les constantes de configuration liées aux statistiques.
    /// Utilisé pour définir les valeurs initiales de santé, d’attaque et les chances de coups critiques.
    /// </summary>
    public static class GameStatConfig
    {
        // Stat du joueur
        // PV de base du joueur
        public const int playerHealthByDefault = 100;

        // Attaque de base du joueur
        public const int playerAttackByDefault = 10;

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