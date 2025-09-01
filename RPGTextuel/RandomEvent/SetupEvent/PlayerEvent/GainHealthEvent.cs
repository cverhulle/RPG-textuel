using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Gain de Points de vie".
    public class GainHealthEvent : IRandomEvent
    {
        // On définit son nom et sa description.
        public string Name => "Délicieux repas";
        public string Description => "Ce délicieux repas vous fait regagner des points de vie !";

        // On définit son activation : 
        // Gain aléatoire entre 10 et 30 PV.
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (player == null) return; // Sécurité

            // On choisit aléatoirement le montant de PV gagné.
            int healAmount = Random.Shared.Next(10, 30);

            // Le joueur se soigne.
            // Le message d'affichage est géré par la méthode Heal.
            player.Heal(healAmount);
        }
    }
}