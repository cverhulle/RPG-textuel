using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Gain de force pour le prochain ennemi
    public class GainStrengthEnemyEvent : RandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Un adversaire impressionnant";
        public override string Description => "D'après les rumeurs, le prochain adversaire est puissant...";

        public override void Trigger(Player player, Enemy enemy)
        {
        }
    }
}