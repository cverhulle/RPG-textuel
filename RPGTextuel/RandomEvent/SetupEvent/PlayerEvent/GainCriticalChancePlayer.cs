using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Utils;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Augmentation de la chance de critique".
    public class GainCriticalChancePlayerEvent : IRandomEvent
    {
        // On définit son nom et sa description.
        public string Name => "Eclair de génie !";
        public string Description => "Un éclair de lucidité traverse votre esprit. Vos prochaines attaques seront plus précises !";

        // On définit l'effet de l'événement : Augmentation de la chance de coup critique.
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (player == null) return; // Sécurité

            player.CriticalHitChance = ModifyStatHelper.ModifyStatWithBounds
                (
                    player.CriticalHitChance,                                       // Stat à modifier (chance de coup critique)
                    0.0, 1.0,                                                       // La chance de coup critique varie entre 0% et 100%
                    0.05, 0.15,                                                     // On augmente la chance de coup critique entre 5% et 15%
                    true,                                                           // On veut réaliser une augmentation
                    "Votre précision est déjà parfaite ! Aucun gain possible.",     // Si la chance de coup critique est déjà à 100%; on personnalise le message
                    "Votre chance de coup critique a augmenté de {0:0.#}% !",       // Affichage pour l'utilisateur
                    "Chance de critique actuelle : {0:0.#}%"                        // Affichage pour l'utilisateur
                );
        }
    }
}