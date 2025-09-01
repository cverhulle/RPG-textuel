using RPGTextuel.Config;
using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Items.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Weight;
using RPGTextuel.Weight.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Trouver un objet".
    public class FindItemEvent : IRandomEvent
    {
        // On définit son nom et sa description.
        public string Name => "Jour de chance";
        public string Description => "Au détour d'un chemin, vous trouvez un objet au sol !";

        // On ajoute la liste des items avec un poids.
        private readonly List<Weighted<Item>> _weightedItems;

        // Constructeur par défaut : utilise les drops par défaut
        public FindItemEvent() : this(ItemDropConfig.DefaultPotionDrops)
        {
        }

        // On définit le constructeur de la classe.
        public FindItemEvent(List<Weighted<Item>> weightedItems)
        {
            _weightedItems = weightedItems ?? throw new ArgumentNullException(nameof(weightedItems));
        }

        // On définit son activation : 
        // Ajout d'un item aléatoire dans l'inventaire du joueur.
        public void Trigger(Player? player, Enemy? enemy)
        {
            if (player == null) return; // sécurité

            Item randomItem = WeightedRandomSelector.SelectRandom(_weightedItems);
            player.Inventory.AddItem(randomItem);
            Console.WriteLine($"Vous avez trouvé un objet : {randomItem.name} !");
        }
    }
}