namespace RPGTextuel.Config
{
    /// <summary>
    /// Contient les constantes globales de configuration du jeu.
    /// Utilisé pour définir les paramètres généraux comme l'affichage de la barre de vie ou la longueur maximale des noms.
    /// </summary>
    public static class GameConfig
    {
        // Barre de vie 
        
        /// <summary>
        /// Taille de la barre de vie, exprimée en nombre de cœurs affichés.
        /// </summary>
        public const int HealthBarLength = 10;

        // Symbole pour un cœur rempli
        public const string FilledHeartSymbol = "🧡 ";

        // Symbole pour un cœur vide
        public const string EmptyHeartSymbol = "🤍 ";

        // Paramètres de jeu 
        // Taille Maximum pour le nom des personnages.
        public const int MaxNameLength = 15;
    }
} 