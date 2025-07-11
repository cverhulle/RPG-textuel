using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;

namespace RPGTextuel.Game.GameFeatures.InitGame
{
    public static class InitGame
    {
        // Cette méthode permet d'initialiser la partie.
        // Elle affiche les messages d'accueils, demande le nom du joueur et l'instancie.
        // Elle s'occupe également de créer la liste des ennemis à affronter pendant cette partie.
        // Elle retourne le joueur ainsi crée de type Player et la liste des ennemis.
        public static (Player player, List<Enemy> ennemies) InitTheGame()
        {
            // On affiche le message d'accueil
            InitWelcomeMessage.ShowWelcomeMessage();

            // On récupère le nom du joueur
            string name = InitPlayerName.AskAndVerifyPlayerName();

            // On crée l'instance de type joueur
            Player player = InitPlayerCreation.CreateAPlayer(name);

            // On crée la liste des ennemis pendant cette partie
            List<Enemy> ennemies = InitEnnemiesToFight.GetRandomGoblinSet();

            // On affiche le dexième message d'accueil
            InitWelcomeMessage.ShowWelcomeMessage2(name);

            return (player, ennemies);
        }
    }
}