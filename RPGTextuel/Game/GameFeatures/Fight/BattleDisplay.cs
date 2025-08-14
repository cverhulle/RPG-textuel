using RPGTextuel.Config;
using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Characters;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Utils;

namespace RPGTextuel.Game.GameFeatures.Fight
{
    // Cette classe s'occupe de l'affichage dans les combats.
    public static class BattleDisplay
    {
        // Cette classe s'occupe d'afficher les infos sur les deux adversaires en combat.
        public static void ShowBattleState(Player player, Enemy enemy)
        {
            Console.Clear();
            Console.WriteLine("===== COMBAT EN COURS =====");

            // Affichage de la santé du joueur
            player.PrintHealthBar();

            // Affichage de la santé de l'ennemi.
            enemy.PrintHealthBar();

            Console.WriteLine("============================");
        }

        // Cette méthode gère l'affichage du résultat du combat.
        public static void ShowBattleResult(Player player, Enemy enemy)
        {
            Console.Clear();

            // On affiche un message relatif au résultat du combat.
            if (player.IsAlive && !enemy.IsAlive)
            {
                ShowEndBattleMessage(
                    "===== FIN DU COMBAT =====\n",
                    $"🎉 Victoire ! {enemy.Name} a été vaincu. \n",
                    GameConfig.victoryColor,
                    () => player.PrintHealthBar()
                );
            }
            else if (!player.IsAlive && enemy.IsAlive)
            {
                ShowEndBattleMessage(
                    "===== FIN DU COMBAT =====\n",
                    $"💀 Défaite... {player.Name} a été terrassé par {enemy.Name}.",
                    GameConfig.defeatColor
                );
            }
            else
            {
                Console.WriteLine("Erreur : Fin prématurée du combat.");
            }
        }

        // Méthode utilitaire pour ShowBattleResult
        // Elle affiche le message de fin de bataille en fonction du résultat.
        private static void ShowEndBattleMessage(string title, string message, ConsoleColor color, Action? extraAction = null)
        {
            DisplayUtils.WriteLineInColor(title, color);
            DisplayUtils.WriteLineInColor(message, color);

            Console.ForegroundColor = color;
            extraAction?.Invoke();
            Console.ForegroundColor = GameConfig.defaultColor;

            GameUtils.WaitForUser("Appuyez sur une touche pour continuer...", color);
        }
    }
}