using RPGTextuel.Core;
using RPGTextuel.Items.Class;

namespace RPGTextuel.Items.SetupItems
{
    /// <summary>
    /// Fournit des méthodes génériques pour gérer les potions.
    /// </summary>
    public static class PotionHelper
    {
        /// <summary>
        /// Donne une potion à un joueur en fonction de la taille choisie.
        /// </summary>
        /// <typeparam name="TPotion">Type de potion à donner, doit hériter de <see cref="Item"/>.</typeparam>
        /// <param name="player">Le joueur qui recevra la potion.</param>
        /// <param name="size">La taille de la potion (<see cref="PotionSize.Small"/>, <see cref="PotionSize.Medium"/>, <see cref="PotionSize.Large"/>).</param>
        /// <param name="potionSelector">Fonction qui sélectionne la potion correspondante à la taille.</param>
        /// <exception cref="ArgumentOutOfRangeException">Lancée si la taille de potion n'est pas reconnue ou si la potion est nulle.</exception>
        public static void GivePotionToPlayer<TPotion>(
            Player player,
            PotionSize size,
            Func<PotionSize, TPotion> potionSelector)
            where TPotion : Item 
        {

            // On appelle la fonction potionSelector. Si tout va bien, on récupère la potion demandée
            TPotion potion = potionSelector(size) ??

                // Sinon, on retourne une erreur
                throw new ArgumentOutOfRangeException(nameof(size), "Taille de potion inconnue");
            
            // On ajoute dans l'inventaire du joueur la potion.
            player.Inventory.AddItem(potion);
        }
    }
}