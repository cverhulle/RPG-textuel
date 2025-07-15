using RPGTextuel.Items.Class;
using RPGTextuel.Items.SetupItems.HealPotions;
using RPGTextuel.Items.SetupItems.DamagePotions;

namespace RPGTextuel.Items.Factory
{
    // Cette classe s'occupe de regrouper tous le objets existants.
    public static class ItemFactory
    {
        // On liste tous les objets existants.
        private static readonly List<Item> allPotions = new List<Item>
        {
            SetupHealPotions.SmallHealPotion,
            SetupHealPotions.MediumHealPotion,
            SetupHealPotions.LargeHealPotion,
            SetupDamagePotions.SmallDamagePotion,
            SetupDamagePotions.MediumDamagePotion,
            SetupDamagePotions.LargeDamagePotion
        };

        // On choisit aléatoirement un objet parmi la liste.
        // public static Item GetRandomItem()
        // {
            // return allPotions.PickRandom();
        // }
    }
}