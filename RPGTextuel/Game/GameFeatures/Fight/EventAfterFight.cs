using RPGTextuel.Config.Enum;
using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Factory;

namespace RPGTextuel.Game.GameFeatures.Fight
{
    // Cette classe permeet de gérer les événements à la fin d'un combat
    public static class EventAfterAFight
    {
        // Cette méthode permet de faire gagner un objet au joueur après un combat en utilisant la table par défaut.
        public static void EarnAnObjet(Player player)
        {
            var objetctToEarn = RandomEventFactory.GetRandomItem(ItemDropTableType.Default);
            objetctToEarn.Trigger(player);
        }
    }
}