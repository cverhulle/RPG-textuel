namespace RPGTextuel.Core.Characters
{
    public abstract partial class Character
    {
        // On définit les attributs de la classe Character.
        private string name;
        private int health;
        private int strength;
        private int maxHealth;

        // On définit les méthodes set et get pour le name.
        // On rejette les noms "null" ou vide.
        public string Name
        {
            get => name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Le nom ne peut pas être vide ou null.");
            }
        }

        // On définit les méthodes set et get pour l'attribut health.
        // On utilise Math pour mettre à 0 les points de vie s'ils tombent en négatif.
        public int Health
        {
            get => health;
            set => health = Math.Max(0, value);
        }

        // On définit les méthodes set et get pour l'attribut strength.
        // On utilise Math pour mettre à 0 les points de force s'ils tombent en négatif.
        public int Strength
        {
            get => strength;
            set => strength = Math.Max(0, value);
        }

        // On définit les méthodes set et get pour l'attribut maxHealth.
        // On utilise Math pour mettre à 0 les points de vie maximum s'ils tombent en négatif.
        public int MaxHealth
        {
            get => maxHealth;
            set => maxHealth = Math.Max(0, value);
        }
    }
}