using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    /// <summary>
    /// Événement aléatoire : le joueur subit une perte de points de vie.
    /// </summary>
    public class LoseHealthEvent : IRandomEvent
    {
        /// <summary>
        /// Nom de l'événement.
        /// </summary>
        public string Name => "Éboulement";

        
        /// <summary>
        /// Description de l'événement.
        /// </summary>
        public string Description => "Une chute de pierre vous blesse légèrement.";

        /// <summary>
        /// Déclenche l'événement : inflige au joueur une perte aléatoire 
        /// comprise entre 5 et 15 points de vie.
        /// </summary>
        /// <param name="player">Le joueur concerné par l'événement (peut être <c>null</c>).</param>
        /// <param name="enemy">L’ennemi concerné (non utilisé ici).</param>
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
            if (player == null) return; // Sécurité

            int damage = Random.Shared.Next(5, 15);
            player.TakeDamage(damage);
        }
    }
}