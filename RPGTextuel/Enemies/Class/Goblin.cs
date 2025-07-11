using RPGTextuel.Enemies.EnemyTypes;

namespace RPGTextuel.Enemies.Class
{
    // On crée un sous-type d'ennemi de type Goblin
    public class Goblin : Enemy
    {
        // Constructeur de la classe
        public Goblin(string name, int health, int strength, int maxHealth)
            : base(name, health, strength, maxHealth, EnemyType.Goblin)
        {
        }

        // Propriété pour afficher le type de l'ennemi.
        public override string DisplayType => "Gobelin";
    }
}