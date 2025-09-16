using RPGTextuel.Items.Class;
using RPGTextuel.Items.SetupItems.DamagePotions;
using RPGTextuel.Items.SetupItems.HealPotions;
using RPGTextuel.Weight.Class;

namespace RPGTextuel.Config
{
    /// <summary>
    /// Contient la configuration des taux de drop des objets.
    /// Définit les probabilités de recevoir certains items après un combat,
    /// que ce soit en combat standard ou contre un boss.
    /// </summary>
    public static class ItemDropConfig
    {
        /// <summary>
        /// Liste pondérée des objets pouvant être obtenus par défaut,
        /// avec leurs probabilités respectives.
        /// </summary>
        /// <remarks>
        /// Les valeurs associées aux items correspondent à leur "poids"
        /// dans la table de loot : plus le nombre est élevé,
        /// plus l’objet a de chances d’être tiré.
        /// </remarks>
        public static readonly List<Weighted<Item>> DefaultPotionDrops = new()
        {
            new Weighted<Item>(SetupHealPotions.SmallHealPotion, 50),
            new Weighted<Item>(SetupHealPotions.MediumHealPotion, 30),
            new Weighted<Item>(SetupHealPotions.LargeHealPotion, 10),
            new Weighted<Item>(SetupDamagePotions.SmallDamagePotion, 40),
            new Weighted<Item>(SetupDamagePotions.MediumDamagePotion, 20),
            new Weighted<Item>(SetupDamagePotions.LargeDamagePotion, 5)
        };

        /// <summary>
        /// Liste pondérée des objets pouvant être obtenus après avoir vaincu un boss.
        /// </summary>
        /// <remarks>
        /// Cette configuration n’est pas encore utilisée dans le jeu,
        /// mais elle permet d’ajouter des récompenses plus intéressantes
        /// après un combat contre un boss.
        /// </remarks>
        public static readonly List<Weighted<Item>> BossItemDrops = new()
        {
            new Weighted<Item>(SetupHealPotions.MediumHealPotion, 30),
            new Weighted<Item>(SetupHealPotions.LargeHealPotion, 20),
            new Weighted<Item>(SetupDamagePotions.MediumDamagePotion, 30),
            new Weighted<Item>(SetupDamagePotions.LargeDamagePotion, 20)
        };
    }
}