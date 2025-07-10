using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;

namespace RPGTextuel.Game.GameFeatures.Fight
{
    // Cette classe est la classe principale qui s'occupe des combats.
    public class MainFight
    {
        // Cette classe s'occupe du déroulé du combat.
        public static void HandleBattle(Player player, Enemy enemy)
        {
            // Tant que les 2 combattants sont en vie, le combat continue.
            while (player.IsAlive && enemy.IsAlive)
            {
                // Affichage des infos de combat.
                BattleDisplay.ShowBattleState(player, enemy);

                // Tour du joueur
                // ------------------- TODO : Test du cas d'utilisation des objets -------------------
                // ---------------------- Modification de PromptUseItem requise pour utiliser un objet sur soi-même -------
                PlayerAction.PlayerTurn(player, enemy);

                // Tour de l'ennemi
            }

            // Résultat du combat. Retour de la fonction ?
        }
    }
}