using RPGTextuel.Core;
using RPGTextuel.Game;
using RPGTextuel.Game.GameFeatures.MainMenu;

class Program
{
    // Cette méthode permet de lancer le programme.
    static void Main(string[] args)
    {
        Player player = new Player("Link");
        // Game.StartGame();
        GameMainMenu.HandleMainMenu(player);
    }
}