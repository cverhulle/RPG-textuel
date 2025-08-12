using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Baisse de la chance de coup critique"
    public class LoseCriticalChancePlayerEvent : RandomEventClass
    {
        // On définit le nom et la description
        public override string Name => "Vision troublée";
        public override string Description => "Une migraine soudaine trouble votre perception... Vos chances de viser juste diminuent.";

        // Cet événement diminue la chance la coup critique du joueur.
        public override void Trigger(Player player)
        {
            // Vérifie si le joueur est déjà à 0%
            if (player.CriticalHitChance <= 0.0)
            {
                Console.WriteLine("Votre précision est déjà au plus bas...");
                return;
            }

            // Réduction entre 0.03 (3%) et 0.1 (10%)
            double penalty = Random.Shared.NextDouble() * 0.07 + 0.03;

            // On applique la pénalité, sans descendre sous 0
            player.CriticalHitChance = Math.Max(0, player.CriticalHitChance - penalty);

            // Messages d'informations pour l'utilisateur.
            Console.WriteLine($"Votre chance de coup critique a diminué de {penalty * 100:0.#}% !");
            Console.WriteLine($"Chance de critique actuelle : {player.CriticalHitChance * 100:0.#}%");
        }
    }
}