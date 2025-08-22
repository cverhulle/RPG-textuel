using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Gain de Points de vie".
    public class GainHealthEvent : PlayerRandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Délicieux repas";
        public override string Description => "Ce délicieux repas vous fait regagner des points de vie !";

        // On définit son activation : 
        // Gain aléatoire entre 10 et 30 PV.
        public override void Trigger(Player player)
        {
            // On choisit aléatoirement le montant de PV gagné.
            int healAmount = Random.Shared.Next(10, 30);

            // Le joueur se soigne.
            // Le message d'affichage est géré par la méthode Heal.
            player.Heal(healAmount);
        }
    }
}