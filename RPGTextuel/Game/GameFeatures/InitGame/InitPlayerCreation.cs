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

            // On donne une petite potion de soin et une autre de taille moyenne au joueur
            player.AddHealPotion(PotionSize.Small);
            player.AddHealPotion(PotionSize.Medium);

            // On donne une petite potion de dégats au joueur
            player.AddDamagePotion(PotionSize.Small);

            // On retourne le joueur crée.
            return player;
        }
    }
}