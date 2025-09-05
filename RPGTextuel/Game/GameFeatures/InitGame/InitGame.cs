using RPGTextuel.Config;
using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.InitGame
{
    public static class InitGame
    {
        // <summary>
        /// Affiche les messages de lancement.
        /// </summary>
        public static void InitMessageBeforeARun(string playerName, bool isReplay)
        {
            // On règle la couleur des textes
            Console.ForegroundColor = TextColorConfig.introColor;
            
            // On affiche le message
            Console.WriteLine();
            InitWelcomeMessage.GetMessageBeforeARun(playerName, isReplay);

            // On laisse le temps à l'utilisateur de lire
            GameUtils.WaitForUser(color: TextColorConfig.introColor);

            // On remet la couleur par défaut.
            Console.ForegroundColor = TextColorConfig.defaultColor;
        }

        /// <summary>
        /// Instancie le joueur et génère la liste des ennemis pour la partie.
        /// On retourne le joueur et la liste d'ennemis
        /// </summary>
        public static (Player player, List<Enemy> ennemies) InitNewRun(string playerName)
        {
            // On crée l'instance de type joueur
            Player player = InitPlayerCreation.CreateAPlayer(playerName);

            // On crée la liste des ennemis pendant cette partie
            List<Enemy> ennemies = InitEnnemiesToFight.GetRandomGoblinSet();

            return (player, ennemies);
        }

        /// <summary>
        /// Demande et retourne le nom du joueur.
        /// </summary>
        public static string InitPlayerIdentityAndWelcomeMessage()
        {
            // On règle la couleur des textes.
            Console.ForegroundColor = TextColorConfig.introColor;

            // On affiche un message d'accueil
            InitWelcomeMessage.ShowWelcomeMessage();

            // On récupère le nom du joueur
            string name = InitPlayerName.AskAndVerifyPlayerName();

            // On reset la couleur des textes.
            Console.ForegroundColor = TextColorConfig.defaultColor;

            return name;
        }
    }
}