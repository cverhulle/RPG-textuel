using RPGTextuel.Items.Consumables;
using RPGTextuel.Core;

namespace RPGTextuel.Items.SetupItems.DamagePotions
{
    public static class SetupDamagePotions
    {
        // Potions prédéfinies
        public static readonly DamagePotion SmallDamagePotion = new DamagePotion("Potion de dégats (petite)", 20);
        public static readonly DamagePotion MediumDamagePotion = new DamagePotion("Potion de dégats (moyenne)", 40);
        public static readonly DamagePotion LargeDamagePotion = new DamagePotion("Potion de dégats (grande)", 60);


        // Cette méthode permet de donner une potion de dégats à un joueur.
        // Elle retourne une erreur si la taille est inconnue.
        public static void GiveDamagePotionToPlayer(Player player, PotionSize size)
        {
            PotionHelper.GivePotionToPlayer(player, size, s => s switch
            {
                PotionSize.Small => SmallDamagePotion,
                PotionSize.Medium => MediumDamagePotion,
                PotionSize.Large => LargeDamagePotion,
                _ => throw new ArgumentOutOfRangeException(nameof(size), "Taille de potion inconnue")
            });
        }
    }
}