using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Utils;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Perte de Force pour le joueur".
    public class LoseStrengthEvent : IRandomEvent
    {
        public string Name => "Blessure musculaire";
        public string Description => "Une mauvaise blessure vous affaiblit...";

        // Activation de l'événement :
        // Perte aléatoire entre 1 et 2 points de Force
        public void Trigger(Player? player, Enemy? enemy)
        {
            if (player == null) return; // Sécurité

            player.Strength = (int)ModifyStatHelper.ModifyStatWithBounds(
                stat: player.Strength,                                              // Stat à modifier
                min: 1,                                                             // Valeur minimale possible
                max: 999,                                                           // Valeur max qu’on s’autorise
                randomMinChange: 1,                                                 // Perte minimale
                randomMaxChange: 2,                                                 // Perte maximale
                increase: false,                                                    // On perd des points
                alreadyAtBoundMessage: "Vous êtes déjà au minimum de force.",
                changeMessageTemplate: "Vous perdez {0} points de force...",        // Ici on n'est pas en %, donc {0} directement
                finalValueMessageTemplate: "Votre force est maintenant de {0}." ,    // Pareil
                isPercentage : false,                                               // La donnée n'est pas en pourcentage
                roundToInt: true                                                     // La force est un entier
            );
        }
    }
}