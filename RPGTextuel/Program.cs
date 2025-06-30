using System;

class Program
{
    static void Main(string[] args)
    {
        // Création du joueur et de l'ennemi
        Joueur joueur = new Joueur("Link");
        Ennemi ennemi = new Ennemi("Gobelin", 50, 8, 50);

        // Affichage initial
        Console.WriteLine($"{joueur.Nom} entre dans l'arène !");
        Console.WriteLine($"Un {ennemi.Nom} apparaît avec {ennemi.Vie} points de vie.");

        // Test d'une attaque
        joueur.Attaquer(ennemi);

        // Test d'un soin
        ennemi.Soigner(5);
        ennemi.Soigner(50);
    }

}