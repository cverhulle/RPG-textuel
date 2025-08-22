using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class;
/*
namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Gain de force pour le prochain ennemi
    public class GainStrengthEnemyEvent : RandomEventClass
    {
        // On définit son nom et sa description.
        public override string Name => "Un adversaire impressionnant";
        public override string Description => "D'après les rumeurs, le prochain adversaire est puissant...";

        public override void Trigger(Enemy enemy)
        {
            // On décide aléatoirement si on augmente ou diminue
            bool buff = Random.Shared.Next(0, 2) == 0; // 50% de chance

            // Montant aléatoire entre 2 et 5
            int delta = Random.Shared.Next(2, 6);

            if (buff)
            {
                enemy.Strength += delta;
                Console.WriteLine($"⚔️ {enemy.Name} se sent surmotivé ! Sa force augmente de {delta} points (→ {enemy.Strength}).");
            }
            else
            {
                enemy.Strength = Math.Max(1, enemy.Strength - delta); // pas en dessous de 1
                Console.WriteLine($"😰 {enemy.Name} est troublé... Sa force diminue de {delta} points (→ {enemy.Strength}).");
            }
        }
    }
}
*/