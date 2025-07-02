using RPGTextuel.Core;
using RPGTextuel.Extensions.Players;
using RPGTextuel.Items.SetupItems.HealPotions;

class Program
{
    static void Main(string[] args)
    {
        // Création du joueur et de l'ennemi
        Player joueur = new Player("Link");

        // On ajoute deux potions au joueur.
        joueur.AddPotion(HealPotionSize.Small);
        joueur.AddPotion(HealPotionSize.Large);
    }
}