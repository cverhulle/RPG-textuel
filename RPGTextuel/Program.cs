using System;
using RPGTextuel;
using RPGTextuel.Items;

class Program
{
    static void Main(string[] args)
    {
        // Création du joueur et de l'ennemi
        Player joueur = new Player("Link");
        Enemy gobelin = new Enemy("Gobelin", 50, 8, 50);

        // Ajout d'objets
        joueur.Inventory.AddItem(new HealPotion("Potion de vie", 25));
        joueur.Inventory.AddItem(new DamagePotion("Potion de dégats", 20));

        // Affichage initial
        Console.WriteLine($"{joueur.Name} arrive dans la bataille");
        Console.WriteLine($"Un {gobelin.Name} apparait avec {gobelin.Health} PV.");

        // Affiche l'inventaire
        joueur.Inventory.DisplayInventory(joueur.Name);

        // Simulation d'un dégât sur le joueur
        joueur.TakeDamage(30);

        // Utilise la potion de soin sur le joueur
        joueur.Inventory.UseItem(0, joueur);

        // Utilise la bombe sur le gobelin
        joueur.Inventory.UseItem(0, gobelin);
    }
}