using RPGTextuel.Config;
using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Items.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Weight;
using RPGTextuel.Weight.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    /// <summary>
    /// Événement aléatoire : le joueur trouve un objet.
    /// </summary>
    public class FindItemEvent : IRandomEvent
    {
        /// <summary>
        /// Nom de l'événement.
        /// </summary>
        public string Name => "Jour de chance";

        /// <summary>
        /// Description de l'événement.
        /// </summary>
        public string Description => "Au détour d'un chemin, vous trouvez un objet au sol !";

        /// <summary>
        /// Liste pondérée des objets pouvant être trouvés.
        /// </summary>
        private readonly List<Weighted<Item>> _weightedItems;

        /// <summary>
        /// Constructeur par défaut, utilise la table de drops par défaut.
        /// </summary>
        public FindItemEvent() : this(ItemDropConfig.DefaultPotionDrops)
        {
        }

        /// <summary>
        /// Initialise un nouvel événement de type <see cref="FindItemEvent"/> 
        /// avec une liste d’objets pondérés.
        /// </summary>
        /// <param name="weightedItems">La liste pondérée des objets disponibles.</param>
        /// <exception cref="ArgumentNullException">
        /// Levée si <paramref name="weightedItems"/> est <c>null</c>.
        /// </exception>
        public FindItemEvent(List<Weighted<Item>> weightedItems)
        {
            _weightedItems = weightedItems ?? throw new ArgumentNullException(nameof(weightedItems));
        }

        /// <summary>
        /// Déclenche l’événement : ajoute un objet aléatoire dans l’inventaire du joueur.
        /// </summary>
        /// <param name="player">Le joueur concerné (peut être null).</param>
        /// <param name="enemy">L’ennemi concerné (non utilisé ici).</param>
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (player == null) return; // sécurité

            Item randomItem = WeightedRandomSelector.SelectRandom(_weightedItems);
            player.Inventory.AddItem(randomItem);
            Console.WriteLine($"Vous avez trouvé un objet : {randomItem.name} !");
        }
    }
}