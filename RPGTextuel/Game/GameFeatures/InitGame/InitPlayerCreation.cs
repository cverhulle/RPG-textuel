using RPGTextuel.Core;
using RPGTextuel.Items.SetupItems;
using RPGTextuel.Extensions.Players;

namespace RPGTextuel.Game.GameFeatures.InitGame
{
    public static class InitPlayerCreation
    {
        // Cette classe permet de créer un personnage à partir de son nom.
        public static Player CreateAPlayer(string playerName)
        {
            // On instance un élément de type Player.
            Player player = new Player(playerName);

            // On donne une potion de soin petite et une autre moyenne au joueur
            player.AddHealPotion(PotionSize.Small);
            player.AddHealPotion(PotionSize.Medium);

            // On donne une potion de dégats petite et une autre moyenne au joueur
            player.AddDamagePotion(PotionSize.Small);
            player.AddDamagePotion(PotionSize.Medium);

            // On retourne le joueur crée.
            return player;
        }
    }
}