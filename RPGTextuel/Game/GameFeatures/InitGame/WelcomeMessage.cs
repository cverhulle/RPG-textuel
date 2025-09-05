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

        /// <summary>
        /// Retourne le message avant le début d’une run.
        /// </summary>
        public static string GetMessageBeforeARun(string name, bool isReplay)
        {
            if (!isReplay)
            {
                string firstMessage = FirstRunMessages[rnd.Next(FirstRunMessages.Length)];
                return firstMessage + "Bienvenue {name} !";
            }
            else
            {
                string replayMessage = ReplayMessages[rnd.Next(ReplayMessages.Length)];
                return replayMessage;
            }
        }
    }
}