using RPGTextuel.Core;
using RPGTextuel.Items.SetupItems;
using RPGTextuel.Items.SetupItems.HealPotions;
using RPGTextuel.Items.SetupItems.DamagePotions;
using RPGTextuel.Extensions.Characters;

namespace RPGTextuel.Extensions.Players
{
    /// <summary>
    /// Fournit des méthodes d’extension pour la classe <see cref="Player"/>.
    /// </summary>
    public static class PlayerExtensions
    {
        /// <summary>
        /// Ajoute une potion de soin à un joueur, selon la taille spécifiée.
        /// </summary>
        /// <param name="player">Le joueur qui recevra la potion.</param>
        /// <param name="size">La taille de la potion de soin.</param>
        /// <exception cref="ArgumentNullException">Si le joueur est <c>null</c>.</exception>
        public static void AddHealPotion(this Player player, PotionSize size)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player), "Le joueur ne peut pas être nul.");
                
            SetupHealPotions.GiveHealPotionToPlayer(player, size);
        }

        // Méthode d’extension pour ajouter une potion de dégats par sa taille.
        public static void AddDamagePotion(this Player player, PotionSize size)
        {
            SetupDamagePotions.GiveDamagePotionToPlayer(player, size);
        }

        // Cette méthode permet d'afficher toutes les statistiques d'un joueur.
        public static void PrintStats(this Player player)
        {
            string title = $" STATISTIQUES DE {player.Name.ToUpper()} ";
            string border = new string('=', title.Length + 12);

            Console.WriteLine($"===== {title.ToUpper()} =====");
            Console.WriteLine($"Nom        : {player.Name}");
            Console.Write("PV         : ");
            player.PrintHealthBar();
            Console.WriteLine($"Force      : {player.Strength}");
            Console.WriteLine($"Critique   : {player.CriticalHitChance * 100:0.##}%");
            Console.WriteLine(border);
        }
    }
}