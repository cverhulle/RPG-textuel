namespace RPGTextuel.Config
{
    // Cette classe s'occupe des couleurs des textes.
    public static class TextColorConfig
    {
        // Couleur des ennemis
        public const ConsoleColor ennemiesColor = ConsoleColor.DarkRed;

        // Couleur des boss
        public const ConsoleColor bossColor = ConsoleColor.Red;

        // Couleur des coups critique 
        public const ConsoleColor critColor = ConsoleColor.Yellow;

        // Couleur de la défaite
        public const ConsoleColor defeatColor = ConsoleColor.DarkRed;

        // Couleur par défaut
        public const ConsoleColor defaultColor = ConsoleColor.Black;

        // Couleur des événements
        public const ConsoleColor eventsColor = ConsoleColor.Blue;

        // Couleur des objets
        public const ConsoleColor itemsColor = ConsoleColor.DarkMagenta;

        // Couleur de l'intro
        public const ConsoleColor introColor = ConsoleColor.Cyan;

        // Couleur pour le joueur
        public const ConsoleColor playerColor = ConsoleColor.Green;

        // Couleur de la victoire
        public const ConsoleColor victoryColor = ConsoleColor.DarkGreen;
    }
}