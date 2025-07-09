using RPGTextuel.Core;
using RPGTextuel.Game;
using RPGTextuel.Enemies.Class;
using RPGTextuel.SetupEnemies;
using RPGTextuel.Game.GameFeatures.Fight;

class Program
{
    // Cette méthode permet de lancer le programme.
    static void Main(string[] args)
    {
        // Méthode pour lancer le jeu
        Game.StartGame();

        /* Test d'un combat
        Player player = new Player("Link");
        Enemy enemy = SetupGoblins.GetRandomGoblin();

        MainFight.HandleBattle(player, enemy);     
        */   
    }
}