using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Perte de Points de vie".
    public class LoseHealthEvent : IRandomEvent
    {
        // On définit son nom et sa description.
        public string Name => "Éboulement";
        public string Description => "Une chute de pierre vous blesse légèrement.";

        // On définit son activation : 
        // Perte aléatoire entre 5 et 15 PV.
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (player == null) return; // Sécurité

            int damage = Random.Shared.Next(5, 15);
            player.TakeDamage(damage);
        }
    }
}