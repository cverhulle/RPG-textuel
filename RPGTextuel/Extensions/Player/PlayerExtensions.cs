using RPGTextuel.Core;
using RPGTextuel.Items.SetupItems;
using RPGTextuel.Items.SetupItems.HealPotions;
using RPGTextuel.Items.SetupItems.DamagePotions;

namespace RPGTextuel.Extensions.Players
{
    // Cette classe permet de définir les extensions de la classe Player
    public static class PlayerExtensions
    {
        // Méthode d’extension pour ajouter une potion de soin par sa taille.
        public static void AddHealPotion(this Player player, PotionSize size)
        {
            SetupHealPotions.GiveHealPotionToPlayer(player, size);
        }
        
        // Méthode d’extension pour ajouter une potion de dégats par sa taille.
        public static void AddDamagePotion(this Player player, PotionSize size)
        {
            SetupDamagePotions.GiveDamagePotionToPlayer(player, size);
        }
    }
}