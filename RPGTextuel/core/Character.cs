namespace RPGTextuel
{
    public abstract partial class Character
    {
        // On implémente le constructeur de la classe.
        protected Character(string characterName, int characterHealth, int characterStrength, int characterMaxHealth)
        {
            name = characterName;
            Health = characterHealth;
            strength = characterStrength;
            MaxHealth = characterMaxHealth;
        }

        // Création de la propriété isAlive pour savoir si un personnage est en vie ou mort.
        public bool IsAlive => Health > 0;
    }
}