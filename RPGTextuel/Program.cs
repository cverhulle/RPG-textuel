using System;

class Program
{
    static void Main(string[] args)
    {
        // Création du joueur et de son ennemi
        Player joueur = new Player("Link");
        Enemy adversaire = new Enemy("Gobelin", 50, 8, 50);

        // Affichage initial
        Console.WriteLine($"{joueur.Name} entre dans l'arène !");
        Console.WriteLine($"Un {adversaire.Name} apparaît avec {adversaire.Health} points de vie.");

        // Test d'une attaque
        joueur.Attack(adversaire);

        // Test d'un soin
        adversaire.Heal(5);
        adversaire.Heal(50);
    }
}