using RPGTextuel.Items.Class;
using RPGTextuel.Items.SetupItems.HealPotions;
using RPGTextuel.Items.SetupItems.DamagePotions;
using RPGTextuel.Extensions.List;

namespace RPGTextuel.Items.Factory
{
    // Cette classe s'occupe de regrouper tous le objets existants.
    public static class ItemFactory
    {
        // On liste tous les objets existants.
        public static readonly List<Item> allPotions = new List<Item>
        {
            SetupHealPotions.SmallHealPotion,
            SetupHealPotions.MediumHealPotion,
            SetupHealPotions.LargeHealPotion,
            SetupDamagePotions.SmallDamagePotion,
            SetupDamagePotions.MediumDamagePotion,
            SetupDamagePotions.LargeDamagePotion
        };

        // On choisit aléatoirement un objet parmi une liste.
        public static Item GetRandomItem(List<Item> items)
        {
            if (items == null || items.Count == 0)
                throw new ArgumentException("La liste ne peut pas être vide");

            return items.PickRandom();
        }
    }
}