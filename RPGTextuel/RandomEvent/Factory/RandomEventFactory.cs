using RPGTextuel.Config;
using RPGTextuel.Config.Enum;
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
        // Renvoie la bonne table de loot
        private static List<Weighted<Item>> GetItemTable(ItemDropTableType dropType) => dropType switch
        {
            ItemDropTableType.Boss => ItemDropConfig.BossItemDrops,
            _ => ItemDropConfig.DefaultPotionDrops
        };

        // Liste de tous les événements disponibles.
        // On stocke des fonctions qui, lorsqu'elles sont appelées, instancient un événement.
        // On fournit le type de drop en entrée.
        private static readonly List<Func<ItemDropTableType, RandomEventClass>> allEventFactories = new()
        {
            (dropType) => new FindItemEvent(GetItemTable(dropType)),
            (_) => new GainHealthEvent(),
            (_) => new LoseHealthEvent(),
            (_) => new LoseItemEvent(),
            (_) => new PeacefulDayEvent()
        };

        // On choisit aléatoirement un événement parmi une liste.
        public static RandomEventClass GetRandomEvent(ItemDropTableType dropType = ItemDropTableType.Default)
        {
            if (allEventFactories == null || allEventFactories.Count == 0)
            {
                return new PeacefulDayEvent();
            }
            var factory = allEventFactories.PickRandom();
            return factory(dropType);
        }
    }
}