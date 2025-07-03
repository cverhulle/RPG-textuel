using RPGTextuel.Game;
using RPGTextuel.GameFeatures;

class Program
{
    static void Main(string[] args)
    {
        GameDisplay.ShowWelcomeMessage(); 
        string name = Game.AskAndVerifyPlayerName();
    }
}