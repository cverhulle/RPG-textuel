namespace RPGTextuel.Config
{
    public static class GameConfig
    {
        // Barre de vie 
        // Taille de la barre de vie (nombre de cœurs)
        public const int HealthBarLength = 10;

        // Symbole pour un cœur rempli
        public const string FilledHeartSymbol = "🧡 ";

        // Symbole pour un cœur vide
        public const string EmptyHeartSymbol = "🤍 ";




        // Paramètre de jeu 
        // Taille Maximum pour le nom des personnages.
        public const int MaxNameLength = 15;




        // Coup critique 
        // Chance de coup critique par défaut
        public const double criticalHitByDefault = 0.05;

        // Chance de coup critique légérement augmenté
        public const double criticalHitAugmented = criticalHitByDefault + 0.1;

        // Chance de coup critique pour le joueur
        public const double criticalHitPlayer = 0.15;

        // Multiplicateur pour des dégats en coup critique
        public const double criticalMultiplicator = 1.4;




        // Couleur des textes
        // Couleur des objets
        public const ConsoleColor itemsColor = ConsoleColor.DarkMagenta;

        // Couleur de l'intro
        public const ConsoleColor introColor = ConsoleColor.Cyan;
    }
} 