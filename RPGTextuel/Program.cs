using RPGTextuel.Core;
using RPGTextuel.Extensions.Characters;

class Program
{
    static void Main(string[] args)
    {
        // Création du joueur et de l'ennemi
        Player joueur = new Player("Link"); 

        joueur.TakeDamage(20);

        // On affiche la barre de vie d'un joueur.
        joueur.PrintHealthBar();
    }
}