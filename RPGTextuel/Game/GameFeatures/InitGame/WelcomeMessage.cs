namespace RPGTextuel.Game.GameFeatures.InitGame
{
    // Cette classe s'occupe de gérer l'affichage pour le jeu.
    public static class InitWelcomeMessage
    {
        // Méthode random pour choisir un message aléatoire
        private static readonly Random rnd = new Random();

        // Messages pour la première partie.
        private static readonly string[] FirstRunMessages =
        {
            "Vous allez devoir affronter trois ennemis redoutables...",
            "Votre courage sera mis à rude épreuve face à vos adversaires...",
            "Trois épreuves mortelles se dressent devant vous..."
        };

        // Messages pour les parties où l'on rejoue.
        private static readonly string[] ReplayMessages =
        {
            "Un nouveau défi vous attend, {0} !",
            "Les ténèbres reviennent, {0}… il est temps de reprendre les armes.",
            "{0}, votre légende n'est pas encore écrite en entier !",
            "Encore une aventure épique pour vous, {0} !"
        };

        // Cette méthode affiche le message de début de jeu
        public static void ShowWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Bienvenue dans AventureRPG ✨");
            Console.WriteLine("Avant de commencer, donnez un nom à votre héros !");
            Console.WriteLine();
        }

        // Cette méthode affiche un message avant le début d'une run.
        public static void ShowMessageBeforeARun(string name)
        {
            Console.WriteLine();
            Console.WriteLine("💥 Bienvenue " + name);
            Console.WriteLine("Vous allez devoir affronter trois ennemis redoutables !");
        }
    }
}