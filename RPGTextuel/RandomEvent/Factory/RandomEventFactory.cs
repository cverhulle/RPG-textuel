using RPGTextuel.Config;
using RPGTextuel.Config.Enum;
using RPGTextuel.Extensions.List;
using RPGTextuel.Items.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.RandomEvent.Events;
using RPGTextuel.RandomEvent.SetupEvent;
using RPGTextuel.Weight.Class;

namespace RPGTextuel.RandomEvent.Factory
{
    /// <summary>
    /// Fournit des méthodes pour créer et gérer les événements aléatoires du jeu.
    /// </summary>
    public static class RandomEventFactory
    {
        /// <summary>
        /// Retourne la table de loot correspondant au type spécifié.
        /// </summary>
        /// <param name="dropType">Le type de table de loot (boss, défaut, etc.).</param>
        /// <returns>La table de loot associée.</returns>
        private static List<Weighted<Item>> GetItemTable(ItemDropTableType dropType) => dropType switch
        {
            ItemDropTableType.Boss => ItemDropConfig.BossItemDrops,
            _ => ItemDropConfig.DefaultPotionDrops
        };

        /// <summary>
        /// Liste de toutes les fabriques d'événements disponibles.
        /// Chaque fabrique est une fonction qui instancie un événement en fonction du type de loot.
        /// </summary>
        private static readonly List<Func<ItemDropTableType, IRandomEvent>> allEventFactories = new()
        {
            (dropType) => new FindItemEvent(GetItemTable(dropType)),
            (_) => new GainHealthEvent(),
            (_) => new LoseHealthEvent(),
            (_) => new LoseItemEvent(),
            (_) => new PeacefulDayEvent(),
            (_) => new GainCriticalChancePlayerEvent(),
            (_) => new LoseCriticalChancePlayerEvent(),
            (_) => new GainStrengthEvent(),
            (_) => new LoseStrengthEvent(),
            (_) => new GainStrengthEnemyEvent(),
            (_) => new LoseStrengthEnemyEvent(),
            (_) => new GainCritEnemyEvent(),
            (_) => new LoseCritEnemyEvent()
        };

        /// <summary>
        /// Retourne un événement aléatoire en fonction du type de loot.
        /// </summary>
        /// <param name="dropType">Le type de loot à utiliser (par défaut : <see cref="ItemDropTableType.Default"/>).</param>
        /// <returns>Un événement aléatoire.</returns>
        public static IRandomEvent GetRandomEvent(ItemDropTableType dropType = ItemDropTableType.Default)
        {
            // S'il n'y a pas d'événement (pas attendu), on ne fait rien.
            if (allEventFactories == null || allEventFactories.Count == 0)
            {
                return new PeacefulDayEvent();
            }

            // sinon, on choisit un événement aléatoirement et, on le retourne
            var factory = allEventFactories.PickRandom();
            return factory(dropType);
        }

        /// <summary>
        /// Retourne un événement qui fait obtenir un objet aléatoire.
        /// </summary>
        /// <param name="dropType">Le type de loot à utiliser (par défaut : <see cref="ItemDropTableType.Default"/>).</param>
        /// <returns>Un événement de type <see cref="FindItemEvent"/>.</returns>
        public static IRandomEvent GetRandomItem(ItemDropTableType dropType = ItemDropTableType.Default)
        {
            return new FindItemEvent(GetItemTable(dropType));
        }
    }
}