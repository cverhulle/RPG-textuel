using RPGTextuel.Core;
using RPGTextuel.Game;
using RPGTextuel.Enemies.Class;
using RPGTextuel.SetupEnemies;
using RPGTextuel.Game.GameFeatures.Fight;
using RPGTextuel.Extensions.Players;
using RPGTextuel.Items.SetupItems;
using RPGTextuel.Game.GameFeatures.InventoryNamespace;

class Program
{
    // Cette méthode permet de lancer le programme.
    static void Main(string[] args)
    {
        // Méthode pour lancer le jeu
        // Game.StartGame();

        // Test d'un combat
        Player player = new Player("Link");
        player.AddHealPotion(PotionSize.Small);
        Enemy enemy = SetupGoblins.GetRandomGoblin();

        MainFight.HandleBattle(player, enemy);        
    }
}