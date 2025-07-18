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

        // Cette fonction permet d'ajouter une potion de soin de taille moyenne dans l'inventaire
        public static void AddMediumHealPotionToInventory(this Player player)
        {
            player.AddHealPotion(PotionSize.Medium);
        }

        // Cette fonction permet d'ajouter une potion de soin de taille moyenne dans l'inventaire
        public static void AddMediumDamagePotionToInventory(this Player player)
        {
            player.AddDamagePotion(PotionSize.Medium);
        }

        // Cette fonction permet d'ajouter une potion de soin de taille "grande" dans l'inventaire
        public static void AddLargeHealPotionToInventory(this Player player)
        {
            player.AddHealPotion(PotionSize.Large);
        }

        // Cette fonction permet d'ajouter une potion de soin de taille "grande" dans l'inventaire
        public static void AddLargeDamagePotionToInventory(this Player player)
        {
            player.AddDamagePotion(PotionSize.Large);
        }
    }
}