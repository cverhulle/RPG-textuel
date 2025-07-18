using RPGTextuel.Core;
using RPGTextuel.Extensions.Players;
using RPGTextuel.Items.SetupItems;

namespace RPGTextuel.Test.Items
{
    // Cette classe regroupe les tests liés aux objets
    public static class ItemTestFactoryUtils
    {
        // Cette fonction permet d'ajouter une potion de soin de taille petite dans l'inventaire
        public static void AddSmallHealPotionToInventory(this Player player)
        {
            player.AddHealPotion(PotionSize.Small);
        }

        // Cette fonction permet d'ajouter une potion de soin de taille petite dans l'inventaire
        public static void AddSmallDamagePotionToInventory(this Player player)
        {
            player.AddDamagePotion(PotionSize.Small);
        }
    }
}