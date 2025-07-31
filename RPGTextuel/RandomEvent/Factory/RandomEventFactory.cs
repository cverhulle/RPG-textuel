using RPGTextuel.Extensions.List;
using RPGTextuel.Items.Class;
using RPGTextuel.RandomEvent.Class;
using RPGTextuel.RandomEvent.SetupEvent;
using RPGTextuel.Weight.Class;

namespace RPGTextuel.RandomEvent.Factory
{
    // Cette classe permet de regrouper tous les évenements aléatoires.
    public static class RandomEventFactory
    {
        // Liste de tous les événements disponibles.
        private static readonly List<RandomEventClass> allEvents = new()
        {
            // -------------- TODO : Gérer l'événement FindItemEvent() -------------------
            // new FindItemEvent(),
            new GainHealthEvent(),
            new LoseHealthEvent(),
            new LoseItemEvent()
        };

        // Cette méthode permet de créer un item pour trouver un objet.
        // En entrée, on donne la liste des objets et leur poids.
        public static RandomEventClass CreateFindItemEvent(List<Weighted<Item>> items)
        {
            return new FindItemEvent(items);
        }

        // On choisit aléatoirement un événement parmi une liste.
        public static RandomEventClass GetRandomEvent(List<RandomEventClass> options)
        {
            if (options == null || options.Count == 0)
            {
                throw new ArgumentException("La liste ne peut pas être vide");
            }
            return options.PickRandom();
        }
    }
}