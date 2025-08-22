using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'évenement "Perte de Points de vie".
    public class LoseHealthEvent : PlayerRandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Éboulement";
        public override string Description => "Une chute de pierre vous blesse légèrement.";

        // On définit son activation : 
        // Perte aléatoire entre 5 et 15 PV.
        public override void Trigger(Player player)
        {
            int damage = Random.Shared.Next(5, 15);
            player.TakeDamage(damage);
        }
    }
}