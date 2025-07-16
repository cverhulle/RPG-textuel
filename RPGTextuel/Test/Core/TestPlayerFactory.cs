using RPGTextuel.Core;

namespace RPGTextuel.Test.Core
{
    // Cette classe regroupe les tests liés à la classe Player.
    public static class TestPlayerFactory
    {
        // Cette fonction permet de créer un personnage nommé Link
        public static Player TestPlayerCreation()
        {
            return new Player("Link");
        }

        // Cette fonction permet de créer le joueur.
        // On ajoute une potion de dégats et une de soin au joueur
        public static Player SetupPlayerAndSmallHealAndDamagePotion()
        {
            Player player = TestPlayerCreation();
            player.TestAddingSmallDamagePotion();
            player.TestAddingSmallHealPotion();
            return player;
        }
    }
}