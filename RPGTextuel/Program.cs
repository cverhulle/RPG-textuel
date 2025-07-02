using RPGTextuel;
using RPGTextuel.Items;

class Program
{
    static void Main(string[] args)
    {
        // Création du joueur et de l'ennemi
        Player joueur = new Player("Link");

        // On récupère un gobelin aléatoire
        var chosenGoblin = SetupEnemies.GoblinChiefs.PickRandom();

        Console.WriteLine($"Un gobelin nommé {chosenGoblin.Name} apparaît avec {chosenGoblin.Health} PV et {chosenGoblin.Strength} ATK !");
    }
}