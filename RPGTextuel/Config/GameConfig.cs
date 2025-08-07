namespace RPGTextuel.Config
{
    public static class GameConfig
    {
        // Taille de la barre de vie (nombre de cœurs)
        public const int HealthBarLength = 10;

        // Symbole pour un cœur rempli
        public const string FilledHeartSymbol = "🧡 ";

        // Symbole pour un cœur vide
        public const string EmptyHeartSymbol = "🤍 ";

        // Taille Maximum pour le nom des personnages.
        public const int MaxNameLength = 15;

        // Chance de coup critique par défaut
        public const double criticalHitByDefault = 0.1;
    }
} 