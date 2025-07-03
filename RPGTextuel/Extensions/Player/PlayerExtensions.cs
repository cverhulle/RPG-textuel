using RPGTextuel.Core;
using RPGTextuel.Items.SetupItems;
using RPGTextuel.Items.SetupItems.HealPotions;


namespace RPGTextuel.Extensions.Players
{   
    // Cette classe permet de définir les extensions de la classe Player
    public static class PlayerExtensions
    {
        // Méthode d’extension pour ajouter une potion par sa taille.
        public static void AddPotion(this Player player, PotionSize size)
        {
            SetupHealPotions.GiveHealPotionToPlayer(player, size);
        }
    }
}