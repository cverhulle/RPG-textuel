using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Gain de force pour le prochain ennemi
    public class GainStrengthEnemyEvent : EnemyRandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Un adversaire impressionnant";
        public override string Description => "D'après les rumeurs, le prochain adversaire est puissant...";

        // On définit l'activation de l'événement.
        public override void Trigger(Enemy enemy)
        {
        }
    }
}
