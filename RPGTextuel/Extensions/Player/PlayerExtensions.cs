using RPGTextuel.Core;
using RPGTextuel.Items.SetupItems;
using RPGTextuel.Items.SetupItems.HealPotions;
using RPGTextuel.Items.SetupItems.DamagePotions;
using RPGTextuel.Extensions.Characters;

namespace RPGTextuel.Extensions.Players
{
    // Cette classe permet de définir les extensions de la classe Player
    public static class PlayerExtensions
    {
        // Méthode d’extension pour ajouter une potion de soin par sa taille.
        public static void AddHealPotion(this Player player, PotionSize size)
        {
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