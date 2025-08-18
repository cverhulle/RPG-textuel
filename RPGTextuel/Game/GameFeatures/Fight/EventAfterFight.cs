using RPGTextuel.Config;
using RPGTextuel.Config.Enum;
using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Factory;

namespace RPGTextuel.Game.GameFeatures.Fight
{
    // Cette classe permeet de gérer les événements à la fin d'un combat
    public static class EventAfterAFight
    {
        // Cette méthode permet de faire gagner un objet au joueur après un combat en utilisant la table par défaut.
        public static void EarnAnItem(Player player)
        {
            // On affiche le texte en couleur
            Console.ForegroundColor = GameConfig.eventsColor;

            // On récupère l'événement à lancer
            var itemToEarn = RandomEventFactory.GetRandomItem(ItemDropTableType.Default);

            // On décleche l'événement (ajout de l'objet dans l'inventaire et affichage)
            itemToEarn.Trigger(player);

            // On remet la couleur par défaut
            Console.ForegroundColor = GameConfig.defaultColor;
        }
    }
}