using RPGTextuel.Core;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Items.Class;

namespace RPGTextuel.Game.GameFeatures.InventoryNamespace
{
    // Cette classe s'occupe des intéractions entre le joueur et son inventaire
    public static class InventoryInteraction
    {
        // Cette méthode demande à l'utilisateur quel objet il souhaite utiliser.
        public static void PromptUseItem(Player player)
        {
            // On récupère l'inventaire du joueur.
            Inventory inventory = player.Inventory;

            // On gère le cas où l'inventaire est vide.
            if (inventory.IsEmpty())
            {
                GameUtils.WaitForUser("Votre inventaire est vide.");
                return;
            }

            while (true)
            {
                
            }
        }
    }
}