using System;
using RPGTextuel.Items;

class Program
{
    static void Main(string[] args)
    {
        // Création du joueur et de son ennemi
        Player joueur = new Player("Link");
        Enemy adversaire = new Enemy("Gobelin", 50, 8, 50);

        // Création d'une potion
        DamagePotion smallPotion = new DamagePotion("Petite Potion", 30);

        // Ajout au sac du joueur
        joueur.AddItem(smallPotion);
        
        // Utilisation de la potion (index 0 dans l’inventaire)
        joueur.UseItem(0);
    }
}