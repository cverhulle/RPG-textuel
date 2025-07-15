using RPGTextuel.Core;
using RPGTextuel.Items.Class;
using RPGTextuel.Items.Factory;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Trouver un objet".
    public class FindItemEvent : RandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Jour de chance";
        public override string Description => "Au détour d'un chemin, vous trouvez un objet au sol !";

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