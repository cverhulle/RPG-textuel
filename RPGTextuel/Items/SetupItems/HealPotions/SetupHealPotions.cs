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
        public static void GiveHealPotionToPlayer(Player player, PotionSize size)
        {
            PotionHelper.GivePotionToPlayer(player, size, s => s switch
            {
                PotionSize.Small => SmallHealPotion,
                PotionSize.Medium => MediumHealPotion,
                PotionSize.Large => LargeHealPotion,
                _ => throw new ArgumentOutOfRangeException(nameof(size), "Taille de potion inconnue")
            });
        }
    }
}