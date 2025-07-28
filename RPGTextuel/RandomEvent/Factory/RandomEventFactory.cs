using RPGTextuel.RandomEvent.Class;
using RPGTextuel.RandomEvent.SetupEvent;

namespace RPGTextuel.RandomEvent.Factory
{
    // Cette classe permet de regrouper tous les évenements aléatoires.
    public static class RandomEventFactory
    {
        // Liste de tous les événements disponibles.
        private static readonly List<RandomEventClass> allEvents = new()
        {
            new FindItemEvent(),
            new GainHealthEvent(),
            new LoseHealthEvent(),
            new LoseItemEvent()
        };

        // On choisit aléatoirement un événement de la liste.
        public static RandomEventClass GetRandomEvent()
        {
            int index = Random.Shared.Next(allEvents.Count);
            return allEvents[index];
        }
    }
}