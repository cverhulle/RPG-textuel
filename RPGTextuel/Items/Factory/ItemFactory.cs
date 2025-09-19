using RPGTextuel.Items.Class;
using RPGTextuel.Items.SetupItems.HealPotions;
using RPGTextuel.Items.SetupItems.DamagePotions;
using RPGTextuel.Extensions.List;

namespace RPGTextuel.Items.Factory
{
    /// <summary>
    /// Fournit une fabrique centralisée pour accéder et générer les différents objets du jeu.
    /// </summary>
    public static class ItemFactory
    {
        /// <summary>
        /// Liste contenant toutes les potions existantes (soin et dégâts).
        /// </summary>
        public static readonly List<Item> allPotions = new List<Item>
        {
            SetupHealPotions.SmallHealPotion,
            SetupHealPotions.MediumHealPotion,
            SetupHealPotions.LargeHealPotion,
            SetupDamagePotions.SmallDamagePotion,
            SetupDamagePotions.MediumDamagePotion,
            SetupDamagePotions.LargeDamagePotion
        };

        /// <summary>
        /// Sélectionne aléatoirement un objet dans une liste d’items.
        /// </summary>
        /// <param name="items">La liste d’items disponibles.</param>
        /// <returns>Un objet choisi aléatoirement dans la liste.</returns>
        /// <exception cref="ArgumentNullException">Lancée si <paramref name="items"/> est <c>null</c>.</exception>
        /// <exception cref="InvalidOperationException">Lancée si <paramref name="items"/> est vide.</exception>
        public static Item GetRandomItem(List<Item> items)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items), "La liste ne peut pas être nulle.");
        
            if (items.Count == 0)
                throw new InvalidOperationException("La liste ne peut pas être vide.");

            return items.PickRandom();
        }
    }
}