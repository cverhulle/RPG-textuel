namespace RPGTextuel.Enemies.Class
{
    // On crée un sous-type d'ennemi de type RedDragon
    public class RedDragon : Enemy
    {
        // On implémente le constructeur de la classe.
        public RedDragon(string name, int health, int strength, int maxHealth, double criticalHitChance = 0.1)
            : base(name, health, strength, maxHealth, EnemyTypes.EnemyType.RedDragon, criticalHitChance)
        {
        }

        // Propriété pour afficher le type de l'ennemi.
        public override string DisplayType => "Dragon Rouge";
    }
}