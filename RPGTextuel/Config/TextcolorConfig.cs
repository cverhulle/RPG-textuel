namespace RPGTextuel.Config
{
    /// <summary>
    /// Contient la configuration des couleurs utilisées pour l’affichage des textes du jeu.
    /// Chaque couleur est associée à un type d’entité, d’événement ou de message spécifique.
    /// </summary>
    public static class TextColorConfig
    {
        /// <summary>
        /// Couleur utilisée pour les ennemis standards.
        /// </summary>
        public const ConsoleColor ennemiesColor = ConsoleColor.DarkRed;

        /// <summary>
        /// Couleur utilisée pour les boss.
        /// </summary>
        public const ConsoleColor bossColor = ConsoleColor.Red;

        /// <summary>
        /// Couleur utilisée pour afficher les coups critiques.
        /// </summary>
        public const ConsoleColor critColor = ConsoleColor.Yellow;

        /// <summary>
        /// Couleur utilisée lors de la défaite du joueur.
        /// </summary>
        public const ConsoleColor defeatColor = ConsoleColor.DarkRed;

        /// <summary>
        /// Couleur par défaut des textes.
        /// </summary>
        public const ConsoleColor defaultColor = ConsoleColor.Black;

        /// <summary>
        /// Couleur utilisée pour afficher les événements spéciaux.
        /// </summary>
        public const ConsoleColor eventsColor = ConsoleColor.Blue;

        /// <summary>
        /// Couleur utilisée pour les objets.
        /// </summary>
        public const ConsoleColor itemsColor = ConsoleColor.DarkMagenta;

        /// <summary>
        /// Couleur utilisée pour le texte d’introduction.
        /// </summary>
        public const ConsoleColor introColor = ConsoleColor.Cyan;

        /// <summary>
        /// Couleur utilisée pour le joueur.
        /// </summary>
        public const ConsoleColor playerColor = ConsoleColor.Green;

        /// <summary>
        /// Couleur utilisée lors d’une victoire.
        /// </summary>
        public const ConsoleColor victoryColor = ConsoleColor.DarkGreen;

        /// <summary>
        /// Couleur utilisée pour l’option permettant de rejouer une partie.
        /// </summary>
        public const ConsoleColor replayColor = ConsoleColor.Yellow;
    }
}