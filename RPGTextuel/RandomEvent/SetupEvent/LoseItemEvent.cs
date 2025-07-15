using RPGTextuel.Core;
using RPGTextuel.Items.Class;
using RPGTextuel.Items.Factory;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    /*
    // On définit l'évenement "Perdre un objet".
    public class LoseItemEvent : RandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Sac percé";
        public override string Description => "Votre sac est percé... un objet semble avoir disparu";


        // On définit son activation : 
        // Perte d'un item aléatoire dans l'inventaire du joueur.
        public override void Trigger(Player player)
        {
            Item itemToLose = ItemFactory.GetRandomItem(player.Inventory.GetAllItems());
            player.Inventory.RemoveItem(itemToLose);
            Console.WriteLine($"Vous avez trouvé un objet : {itemToLose.name} !");
        }
    }
    */
}