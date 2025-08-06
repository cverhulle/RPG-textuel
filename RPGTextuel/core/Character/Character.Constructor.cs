namespace RPGTextuel.Core.Characters
{
    public abstract partial class Character
    {
        // On implémente le constructeur de la classe.
        protected Character(string characterName, int characterHealth, int characterStrength, int characterMaxHealth, double criticalHitChance = 0.05)
        {
            name = characterName;
            Health = characterHealth;
            strength = characterStrength;
            MaxHealth = characterMaxHealth;
            CriticalHitChance = criticalHitChance;
        }

        // Création de la propriété isAlive pour savoir si un personnage est en vie ou mort.
        public bool IsAlive => Health > 0;
    }
}