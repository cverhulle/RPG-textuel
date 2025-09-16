namespace RPGTextuel.Config
{
    /// <summary>
    /// Contient les constantes globales de configuration du jeu.
    /// Utilisé pour définir les paramètres généraux comme l'affichage de la barre de vie ou la longueur maximale des noms.
    /// </summary>
    public static class GameConfig
    {
        // --- Barre de vie ---

        /// <summary>
        /// Taille de la barre de vie, exprimée en nombre de cœurs affichés.
        /// </summary>
        public const int HealthBarLength = 10;

        /// <summary>
        /// Symbole Unicode représentant un cœur rempli.
        /// Utilisé pour indiquer les points de vie restants.
        /// </summary>
        public const string FilledHeartSymbol = "🧡 ";

        /// <summary>
        /// Symbole Unicode représentant un cœur vide.
        /// Utilisé pour indiquer les points de vie manquants.
        /// </summary>
        public const string EmptyHeartSymbol = "🤍 ";

        // --- Paramètres de jeu ---
        
        /// <summary>
        /// Longueur maximale autorisée pour le nom d’un personnage.
        /// </summary>
        public const int MaxNameLength = 15;
    }
} 