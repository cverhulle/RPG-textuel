using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;

namespace RPGTextuel.Game.GameFeatures.Fight
{
    // Cette méthode gère le tour d'action du joueur
    public static class PlayerAction
    {
        // Cette méthode gère le tour du joueur.
        public static void PlayerTurn(Player player, Enemy enemy)
        {
            // On crée le booléen asActed pour savoir si le joueur a terminé son tour ou non.
            bool hasActed = false;

            // Tant que le joueur ne termine pas son tour, on reste dans la méthode.
            while (!hasActed)
            {

            }
        }
    }
}