using RPGTextuel.Items.Consumables;
using RPGTextuel.Core;

namespace RPGTextuel.Items.SetupItems.HealPotions
{
    public static class SetupHealPotions
    {
        // Potions prédéfinies
        public static readonly HealPotion SmallHealPotion = new HealPotion("Potion de soin (petite)", 30);
        public static readonly HealPotion MediumHealPotion = new HealPotion("Potion de soin (moyenne)", 60);
        public static readonly HealPotion LargeHealPotion = new HealPotion("Potion de soin (grande)", 100);


        // Cette méthode permet de donner une potion à un joueur
        // Elle retourne une erreur si la taille est inconnue.
        public static void GiveHealPotionToPlayer(Player player, HealPotionSize size)
        {
            HealPotion potion = size switch
            {
                HealPotionSize.Small => SmallHealPotion,
                HealPotionSize.Medium => MediumHealPotion,
                HealPotionSize.Large => LargeHealPotion,
                _ => throw new ArgumentOutOfRangeException(nameof(size), "Taille de potion inconnue")
            };

            player.Inventory.AddItem(potion);
        }
    }
}