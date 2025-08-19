using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Gain de Points de vie".
    public class GainStrengthEvent : RandomEventClass
    {
        // Nom et description de l'événement
        public override string Name => "Entraînement intensif";
        public override string Description => "Votre entraînement acharné vous rend plus fort !";

        // Activation de l'événement :
        // Gain aléatoire entre 1 et 3 points de Force
        public override void Trigger(Player player)
        {
        }
    }
}