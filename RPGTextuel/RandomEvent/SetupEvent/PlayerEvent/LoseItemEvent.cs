using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Items.Class;
using RPGTextuel.RandomEvent.Class.Interface;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Perdre un objet".
    public class LoseItemEvent : IRandomEvent
    {
        // On définit son nom et sa description.
        public string Name => "Sac percé";
        public string Description => "Votre sac est percé... un objet semble avoir disparu";


        // On définit son activation : 
        // Perte d'un item aléatoire dans l'inventaire du joueur.
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (player == null) return; // Sécurité

            // On récupère le nombre d'objet du player.
            int inventoryLength = player.Inventory.Count;

            // Si l'inventaire est vide, on ne fait rien.
            if (inventoryLength == 0)
            {
                Console.WriteLine("Vous n'avez aucun objet à perdre.");
                return;
            }

            // On choisit aléatoirement l'index de l'objet perdu.
            Random rng = new Random();
            int index = rng.Next(inventoryLength);

            // On affiche le message à l'utilisateur
            Item item = player.Inventory.GetAllItems()[index];
            Console.WriteLine($"Vous avez perdu {item.name}");

            // On retire l'objet.
            player.Inventory.RemoveItemByIndex(index);
        }
    }
}