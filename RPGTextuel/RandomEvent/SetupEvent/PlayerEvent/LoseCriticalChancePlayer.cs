using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Class;
using RPGTextuel.Utils;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Baisse de la chance de coup critique"
    public class LoseCriticalChancePlayerEvent : PlayerRandomEventClass
    {
        // On définit le nom et la description
        public override string Name => "Vision troublée";
        public override string Description => "Une migraine soudaine trouble votre perception... Vos chances de viser juste diminuent.";

        // Cet événement diminue la chance la coup critique du joueur.
        public override void Trigger(Player player)
        {
            player.CriticalHitChance = ModifyStatHelper.ModifyStatWithBounds
                (
                    player.CriticalHitChance,                                   // Stat à modifier (chance de coup critique)
                    0.0, 1.0,                                                   // La chance de coup critique varie entre 0% et 100%
                    0.03, 0.10,                                                 // On diminue la chance de coup critique entre 3% et 10%
                    false,                                                      // On veut réaliser une diminution
                    "Votre précision est déjà au plus bas...",                  // Si la chance de coup critique est déjà à 0%; on personnalise le message
                    "Votre chance de coup critique a diminué de {0:0.#}% !",    // Affichage pour l'utilisateur
                    "Chance de critique actuelle : {0:0.#}%"                    // Affichage pour l'utilisateur
                );  
        }
    }
}