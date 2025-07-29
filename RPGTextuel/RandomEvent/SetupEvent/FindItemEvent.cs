using RPGTextuel.Core;
using RPGTextuel.Items.Class;
using RPGTextuel.Items.Factory;
using RPGTextuel.RandomEvent.Class;
using RPGTextuel.Weight.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Trouver un objet".
    public class FindItemEvent : RandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Jour de chance";
        public override string Description => "Au détour d'un chemin, vous trouvez un objet au sol !";

        // On ajoute la liste des items avec un poids.
        private readonly List<Weighted<Item>> _weightedItems;

        // On définit le constructeur de la classe.
        public FindItemEvent(List<Weighted<Item>> weightedItems)
        {
            _weightedItems = weightedItems ?? throw new ArgumentNullException(nameof(weightedItems));
        }

        // On définit son activation : 
        // Ajout d'un item aléatoire dans l'inventaire du joueur.
        public override void Trigger(Player player)
        {
            Item randomItem = ItemFactory.GetRandomItem(ItemFactory.allPotions);
            player.Inventory.AddItem(randomItem);
            Console.WriteLine($"Vous avez trouvé un objet : {randomItem.name} !");
        }
    }
}