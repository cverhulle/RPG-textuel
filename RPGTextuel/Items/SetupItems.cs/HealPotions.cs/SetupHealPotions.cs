using RPGTextuel.Items.Consumables;

namespace RPGTextuel.Items.SetupItems.HealPotions
{
    public static class SetupHealPotions
    {
        // Potions prédéfinies
        public static readonly HealPotion SmallHealPoition = new HealPotion("Potion de soin (petite)", 30);
        public static readonly HealPotion MediumHealPotion = new HealPotion("Potion de soin (moyenne)", 60);
        public static readonly HealPotion LargeHealPotion = new HealPotion("Potion de soin (grande)", 100);
    }
}