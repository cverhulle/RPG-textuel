using RPGTextuel.Core;
using RPGTextuel.Items.Class;

namespace RPGTextuel.Items.SetupItems
{
    // Cette classe fournit les méthodes génériques liées aux potions
    public static class PotionHelper
    {
        // Cette méthode est une méthode générique pour donner des potions à un joueur.
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