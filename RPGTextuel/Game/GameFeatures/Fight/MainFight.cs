using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;

namespace RPGTextuel.Game.GameFeatures.Fight
{
    // Cette classe est la classe principale qui s'occupe des combats.
    public class MainFight
    {
        // Cette classe s'occupe du déroulé du combat.
        public static void HandleBattle(Player player, Enemy enemy, bool isFinalBoss)
        {
            // Tant que les 2 combattants sont en vie, le combat continue.
            while (player.IsAlive && enemy.IsAlive)
            {
                // Affichage des infos de combat.
                BattleDisplay.ShowBattleState(player, enemy);

                // Tour du joueur
                PlayerAction.PlayerTurn(player, enemy);

                // Tour de l'ennemi
                if (enemy.IsAlive)
                {
                    EnemyAction.EnemyTurn(player, enemy, isFinalBoss);
                }
            }

            // Résultat du combat. Retour de la fonction ?
            BattleDisplay.ShowBattleResult(player, enemy);
        }
    }
}