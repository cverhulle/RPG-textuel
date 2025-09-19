using RPGTextuel.Items.Consumables;
using RPGTextuel.Core;

namespace RPGTextuel.Items.SetupItems.HealPotions
{
    /// <summary>
    /// Contient la définition des potions de soin disponibles et les méthodes associées.
    /// </summary>
    public static class SetupHealPotions
    {
        /// <summary>
        /// Potion de soin de petite taille (30 points de vie).
        /// </summary>
        public static readonly HealPotion SmallHealPotion = new HealPotion("Potion de soin (petite)", 30);

        /// <summary>
        /// Potion de soin de taille moyenne (60 points de vie).
        /// </summary>
        public static readonly HealPotion MediumHealPotion = new HealPotion("Potion de soin (moyenne)", 60);

        /// <summary>
        /// Potion de soin de grande taille (100 points de vie).
        /// </summary>
        public static readonly HealPotion LargeHealPotion = new HealPotion("Potion de soin (grande)", 100);


        /// <summary>
        /// Ajoute une potion de soin à l'inventaire d'un joueur en fonction de la taille choisie.
        /// </summary>
        /// <param name="player">Le joueur qui recevra la potion.</param>
        /// <param name="size">La taille de la potion (<see cref="PotionSize.Small"/>, <see cref="PotionSize.Medium"/>, <see cref="PotionSize.Large"/>).</param>
        /// <exception cref="ArgumentOutOfRangeException">Lancée si la taille de la potion n'est pas reconnue.</exception>
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