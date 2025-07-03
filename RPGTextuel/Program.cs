using RPGTextuel.Game;

class Program
{
    static void Main(string[] args)
    {
        GameDisplay.ShowWelcomeMessage(); 
        string name = Game.AskAndVerifyPlayerName();
    }
}