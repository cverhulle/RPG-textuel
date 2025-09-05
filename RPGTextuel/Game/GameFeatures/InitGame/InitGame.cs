using RPGTextuel.Config;
using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.InitGame
{
    public static class InitGame
    {
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
        public static string InitPlayerIdentity()
        {
            // On règle la couleur des textes.
            Console.ForegroundColor = TextColorConfig.introColor;

            // On récupère le nom du joueur
            string name = InitPlayerName.AskAndVerifyPlayerName();

            // On reset la couleur des textes.
            Console.ForegroundColor = TextColorConfig.defaultColor;

            return name;
        }
    }
}