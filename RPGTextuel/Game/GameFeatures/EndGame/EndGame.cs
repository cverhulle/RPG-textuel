using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.EndGame
{
    // Cette classe s'occupe de gérer la fin de partie
    public static class EndGame
    {
        // Cette méthode gère l'affichage en cas de victoire du joueur.
        public static void VictoryMessage()
        {
            Console.Clear();
            Console.WriteLine("🎉 Félicitations ! Vous avez vaincu tous les ennemis !");
            GameUtils.WaitForUser();
        }
    }
}