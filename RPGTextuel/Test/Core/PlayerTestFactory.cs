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
            player.AddSmallHealPotionToInventory(); // !!! Potion de Soin en premier.
            player.AddSmallDamagePotionToInventory();
            return player;
        }

        // Création d'un joueur blessé
        public static Player CreateWoundedPlayer(int damage)
        {
            Player player = CreateBasicTestPlayer();
            player.TakeDamage(damage);
            return player;
        }

        // Création d'un joueur blessé avec deux petites potions.
        public static Player CreateWoundedPlayerWithPotions(int damage)
        {
            Player player = CreatePlayerWithHealAndDamagePotions();
            player.TakeDamage(damage);
            return player;
        }

        // Cette méthode permet de créer un joueur mort.
        public static Player CreateDeadPlayer()
        {
            Player player = new Player("Héros mort");
            player.Health = 0;  // Simule la mort
            return player;
        }
    }
}