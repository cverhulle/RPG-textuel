using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.Fight
{
    // Cette méthode gère le tour d'action du joueur
    public static class PlayerAction
    {
        // On liste les actions possibles pour un joueur pendant son tour.
        private static readonly List<string> playersAction = new List<string>
        {
            "Attaquer",
            "Utiliser un objet",
            "Voir les stats de l'ennemi",
            "Voir mes stats"
        };

        // Cette méthode gère le tour du joueur.
        public static void PlayerTurn(Player player, Enemy enemy)
        {
            Console.WriteLine("/n===== VOTRE TOUR =====");

            // On crée le booléen asActed pour savoir si le joueur a terminé son tour ou non.
            bool hasActed = false;

            // Tant que le joueur ne termine pas son tour, on reste dans la méthode.
            while (!hasActed)
            {
                // On demande le choix de l'utilisateur.
                int choice = GameInputUser.AskMenuChoice(playersAction, "Que souhaitez-vous faire ?");

                switch (choice)
                {
                    // Attaque
                    case 1: 
                        break;

                    // Objet
                    case 2:
                        break;

                    // Voir les stats de l'adversaire
                    case 3: 
                        break;

                    // Voir mes stats
                    case 4: 
                        break;
                }
            }
        }
    }
}