using RPGTextuel.Core;
using RPGTextuel.Test.Items;

namespace RPGTextuel.Test.Core
{
    // Fournit des instances de Player prédéfinis pour les tests.
    public static class PlayerTestFactory
    {
        // Cette fonction permet de créer un personnage nommé Link
        public static Player CreateBasicTestPlayer()
        {
            return new Player("Link");
        }

        // Cette fonction permet de créer le joueur.
        // On ajoute une potion de dégats et une de soin au joueur
        public static Player CreatePlayerWithHealAndDamagePotions()
        {
            Player player = CreateBasicTestPlayer();
            player.TestAddingSmallHealPotion();
            player.TestAddingSmallDamagePotion();
            return player;
        }

        // Joueur blessé
        public static Player CreateWoundedPlayer(int damage)
        {
            Player player = CreateBasicTestPlayer();
            player.TakeDamage(damage);
            return player;
        }
    }
}