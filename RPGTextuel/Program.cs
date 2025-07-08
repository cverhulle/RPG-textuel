using RPGTextuel.Core;
using RPGTextuel.Extensions.Players;
using RPGTextuel.Game.GameFeatures.MainMenu;
using RPGTextuel.Items.SetupItems;

class Program
{
    // Cette méthode permet de lancer le programme.
    static void Main(string[] args)
    {
        Player player = new Player("Link");

        player.AddHealPotion(PotionSize.Small);
        player.AddDamagePotion(PotionSize.Small);
        // Game.StartGame();
        GameMainMenu.HandleMainMenu(player);
    }
}