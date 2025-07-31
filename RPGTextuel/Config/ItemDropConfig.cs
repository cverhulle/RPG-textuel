using RPGTextuel.Items.Class;
using RPGTextuel.Items.SetupItems.DamagePotions;
using RPGTextuel.Items.SetupItems.HealPotions;
using RPGTextuel.Weight.Class;

namespace RPGTextuel.Config
{
    // Cette classe permet de gérer le taux de drop des objets.
    public static class ItemDropConfig
    {
        // Taux de drop des objets par défaut.
        public static readonly List<Weighted<Item>> DefaultPotionDrops = new()
        {
            new Weighted<Item>(SetupHealPotions.SmallHealPotion, 50),
            new Weighted<Item>(SetupHealPotions.MediumHealPotion, 30),
            new Weighted<Item>(SetupHealPotions.LargeHealPotion, 10),
            new Weighted<Item>(SetupDamagePotions.SmallDamagePotion, 40),
            new Weighted<Item>(SetupDamagePotions.MediumDamagePotion, 20),
            new Weighted<Item>(SetupDamagePotions.LargeDamagePotion, 5)
        };

        // Taux de drop des objets après avoir vaincu un boss.
        public static readonly List<Weighted<Item>> BossItemDrops = new()
        {
            new Weighted<Item>(SetupHealPotions.MediumHealPotion, 30),
            new Weighted<Item>(SetupHealPotions.LargeHealPotion, 20),
            new Weighted<Item>(SetupDamagePotions.MediumDamagePotion, 30),
            new Weighted<Item>(SetupDamagePotions.LargeDamagePotion, 20)
        };
    }
}