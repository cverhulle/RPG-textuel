namespace RPGTextuel.Game.GameFeatures
{
    public class GameMainMenu
    {   
        // Cette variable contient les options du menu principal.
        public static readonly List<string> MainMenuChoice = new List<string>
        {
            "Passer au combat suivant.",
            "Statistiques",
            "Voir l'inventaire.",
            "Quitter le jeu"
        };

        // Cette méthode affiche le menu principal.
        // Elle retourne le choix, valide, de l'utilisateur
        public static void AskMainMenuChoice()
        {
            Console.Clear();
            int input = GameInputUser.AskMenuChoice(MainMenuChoice, "MENU PRINCIPAL");
        }

    }
}