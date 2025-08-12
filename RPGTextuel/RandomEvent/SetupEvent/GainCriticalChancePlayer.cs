using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Augmentation de la chance de critique".
    public class GainCriticalChancePlayerEvent : RandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Eclair de génie !";
        public override string Description => "Un éclair de lucidité traverse votre esprit. Vos prochaines attaques seront plus précises !";

        // On définit l'effet de l'événement : Augmentation de la chance de coup critique.
        public override void Trigger(Player player)
        {
            // Vérifie si le joueur est déjà à 100%
            if (player.CriticalHitChance >= 1.0)
            {
                Console.WriteLine("Votre précision est déjà parfaite ! Aucun gain possible.");
                return;
            }

            // On définit le boost entre 0.05 (5%) et 0.15 (15%)
            double boost = Random.Shared.NextDouble() * 0.1 + 0.05;

            // On calcule ce qu'il manque pour arriver à 100%
            double manque = 1.0 - player.CriticalHitChance;

            // Si le boost dépasse ce qu'il manque, on le limite
            if (boost > manque)
            {
                boost = manque;
            }

            // On ajoute le boost au joueur.
            player.CriticalHitChance += boost;

            // On affiche un message d'information.
            Console.WriteLine($"Votre chance de coup critique a augmenté de {boost * 100:0.#}% !");
            Console.WriteLine($"Chance de critique actuelle : {player.CriticalHitChance * 100:0.#}%");
        }
    }
}