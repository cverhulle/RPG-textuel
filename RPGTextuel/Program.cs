using RPGTextuel;
using RPGTextuel.Items;

class Program
{
    static void Main(string[] args)
    {
        // Création du joueur et de l'ennemi
        Player joueur = new Player("Link");

        // On récupère un gobelin aléatoire
        Random rng = new Random();
        var goblins = SetupEnemies.GoblinMinions;
        var chosenGoblin = goblins[rng.Next(goblins.Count)];

        Console.WriteLine($"Un gobelin nommé {chosenGoblin.Name} apparaît avec {chosenGoblin.Health} PV et {chosenGoblin.Strength} ATK !");

        // Le gobelin attaque le joueur.
        chosenGoblin.Attack(joueur);
    }
}