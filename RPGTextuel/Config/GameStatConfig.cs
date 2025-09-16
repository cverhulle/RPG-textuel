namespace RPGTextuel.Config
{
    /// <summary>
    /// Contient les constantes de configuration liées aux statistiques.
    /// Utilisé pour définir les valeurs initiales de santé, d’attaque et les chances de coups critiques.
    /// </summary>
    public static class GameStatConfig
    {
        // --- Statistiques du joueur ---

        /// <summary>
        /// Points de vie initiaux du joueur.
        /// </summary>
        public const int playerHealthByDefault = 100;

        /// <summary>
        /// Valeur d’attaque de base du joueur.
        /// </summary>
        public const int playerAttackByDefault = 10;

        // --- Coup critique ---
        
        /// <summary>
        /// Probabilité par défaut de réussir un coup critique (5%).
        /// </summary>
        public const double criticalHitByDefault = 0.05;

        /// <summary>
        /// Probabilité d’un coup critique légèrement augmentée (par défaut +10%).
        /// </summary>
        public const double criticalHitAugmented = criticalHitByDefault + 0.1;

        /// <summary>
        /// Probabilité d’un coup critique spécifique au joueur (15%).
        /// </summary>
        public const double criticalHitPlayer = 0.15;

        /// <summary>
        /// Multiplicateur appliqué aux dégâts en cas de coup critique.
        /// </summary>
        public const double criticalMultiplicator = 1.4;
    }
}