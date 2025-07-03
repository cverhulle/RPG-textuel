using RPGTextuel.Core;
using RPGTextuel.Items.SetupItems.HealPotions;

namespace RPGTextuel.Game.GameFeatures
{
    public static class CreatePlayer
    {
        // Cette classe permet de créer un personnage à partir de son nom.
        public static Player CreateAPlayer(string playerName)
        {
            // On instance un élément de type Player.
            Player player = new Player(playerName);

            // On donne une potion de soin petite et une autre moyenne au joueur
            SetupHealPotions.GiveHealPotionToPlayer(player, HealPotionSize.Medium);

            // On retourne le joueur crée.
            return player;
        }
    }
}