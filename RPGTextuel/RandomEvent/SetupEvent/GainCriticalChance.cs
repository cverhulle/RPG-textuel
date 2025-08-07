using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Augmentation de la chance de critique".
    public class GainCriticalChanceEvent : RandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Eclair de génie !";
        public override string Description => "Un éclair de lucidité traverse votre esprit. Vos prochaines attaques seront plus précises !";

        // On définit l'effet de l'événement : Augmentation de la chance de coup critique.
        public override void Trigger(Player player)
        {
            // On définit le boost entre 0.05 (5%) et 0.15 (15%)
            double boost = Random.Shared.NextDouble() * 0.1 + 0.05;

            // On applique le boost à la chance de coup critique du joueur
            player.CriticalHitChance = Math.Min(1, player.CriticalHitChance + boost);

            // On affiche un message d'information.
            Console.WriteLine($"Votre chance de coup critique a augmenté de {boost * 100:0.#}% !");
            Console.WriteLine($"Chance de critique actuelle : {player.CriticalHitChance * 100:0.#}%");
        }
    }
}