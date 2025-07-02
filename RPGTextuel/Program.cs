using RPGTextuel.Core;
using RPGTextuel.Items.SetupItems.HealPotions;

class Program
{
    static void Main(string[] args)
    {
        // Création du joueur et de l'ennemi
        Player joueur = new Player("Link");

        // On ajoute trois potions au joueur.
        SetupHealPotions.GiveHealPotionToPlayer(joueur, HealPotionSize.Small);
        SetupHealPotions.GiveHealPotionToPlayer(joueur, HealPotionSize.Medium);
        SetupHealPotions.GiveHealPotionToPlayer(joueur, HealPotionSize.Large);
    }
}