using RPGTextuel.Config;
using RPGTextuel.Config.Enum;
using RPGTextuel.Core;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.RandomEvent.Factory;

namespace RPGTextuel.Game.GameFeatures.Fight
{
    // Cette classe permeet de gérer les événements à la fin d'un combat
    public static class EventAfterAFight
    {
        // Cette méthode permet de faire gagner un objet au joueur après un combat en utilisant la table par défaut.
        // Après le boss final ou si le joueur est mort, on ne gagne pas d'objet.
        public static void EarnAnItem(Player player, Boolean isFinalBoss)
        {
            // Si c'est le boss final, on ne fait rien.
            // De même si le joueur est mort.
            if (!player.IsAlive || isFinalBoss)
            {
                return;
            }
                    
            // On affiche le texte en couleur
            Console.ForegroundColor = TextColorConfig.eventsColor;

            // On récupère l'événement à lancer
            var itemToEarn = RandomEventFactory.GetRandomItem(ItemDropTableType.Default);

            // On décleche l'événement (ajout de l'objet dans l'inventaire et affichage)
            Console.Write("===== RECOMPENSE DE FIN DE COMBAT ===== \n");
            itemToEarn.Trigger(player);

            // On laisse à l'utilisateur le temps de lire l'affichage
            GameUtils.WaitForUser(color: TextColorConfig.eventsColor);

            // On remet la couleur par défaut
            Console.ForegroundColor = TextColorConfig.defaultColor;
        }
    }
}