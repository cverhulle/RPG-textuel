using RPGTextuel.Items.Consumables;
using RPGTextuel.Core;

namespace RPGTextuel.Items.SetupItems.DamagePotions
{
    /// <summary>
    /// Contient la définition des potions de dégâts disponibles et les méthodes associées.
    /// </summary>
    public static class SetupDamagePotions
    {
        /// <summary>
        /// Potion de dégâts de petite taille (20 dégâts).
        /// </summary>
        public static readonly DamagePotion SmallDamagePotion = new DamagePotion("Potion de dégats (petite)", 20);

        /// <summary>
        /// Potion de dégâts de taille moyenne (40 dégâts).
        /// </summary>
        public static readonly DamagePotion MediumDamagePotion = new DamagePotion("Potion de dégats (moyenne)", 40);

        /// <summary>
        /// Potion de dégâts de grande taille (60 dégâts).
        /// </summary>
        public static readonly DamagePotion LargeDamagePotion = new DamagePotion("Potion de dégats (grande)", 60);


        /// <summary>
        /// Ajoute une potion de dégâts à l'inventaire d'un joueur en fonction de la taille choisie.
        /// </summary>
        /// <param name="player">Le joueur qui recevra la potion.</param>
        /// <param name="size">La taille de la potion (<see cref="PotionSize.Small"/>, <see cref="PotionSize.Medium"/>, <see cref="PotionSize.Large"/>).</param>
        /// <exception cref="ArgumentOutOfRangeException">Lancée si la taille de la potion n'est pas reconnue.</exception>
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