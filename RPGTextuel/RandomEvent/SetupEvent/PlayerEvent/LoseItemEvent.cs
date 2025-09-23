using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Items.Class;
using RPGTextuel.RandomEvent.Class.Interface;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    /// <summary>
    /// Événement aléatoire : le joueur perd un objet de son inventaire.
    /// </summary>
    public class LoseItemEvent : IRandomEvent
    {
        /// <summary>
        /// Nom de l'événement.
        /// </summary>
        public string Name => "Sac percé";

        /// <summary>
        /// Description de l'événement.
        /// </summary>
        public string Description => "Votre sac est percé... un objet semble avoir disparu";


        /// <summary>
        /// Déclenche l'événement : retire un objet aléatoire de l'inventaire du joueur,
        /// si celui-ci n'est pas vide.
        /// </summary>
        /// <param name="player">Le joueur concerné par l'événement (peut être <c>null</c>).</param>
        /// <param name="enemy">L’ennemi concerné (non utilisé ici).</param>
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