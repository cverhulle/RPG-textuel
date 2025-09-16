namespace RPGTextuel.Core.Characters
{
    /// <summary>
    /// Classe de base abstraite représentant un personnage du jeu.
    /// Fournit les attributs communs tels que la santé, la force, 
    /// la santé maximale et la probabilité de coup critique.
    /// </summary>
    public abstract partial class Character
    {
        // On définit les attributs de la classe Character.
        private string name;
        private int health;
        private int strength;
        private int maxHealth;
        private double criticalHitChance;

        /// <summary>
        /// Nom du personnage.
        /// Le nom ne peut pas être vide ou composé uniquement d’espaces.
        /// </summary>
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

        /// <summary>
        /// Points de vie actuels du personnage.
        /// Ne peut jamais être inférieur à 0.
        /// </summary>
        public int Health
        {
            get => health;
            set => health = Math.Max(0, value);
        }

        /// <summary>
        /// Force d’attaque du personnage.
        /// Ne peut jamais être négative.
        /// </summary>
        public int Strength
        {
            get => strength;
            set => strength = Math.Max(0, value);
        }

        /// <summary>
        /// Points de vie maximum du personnage.
        /// Ne peut jamais être inférieur à 0.
        /// </summary>
        public int MaxHealth
        {
            get => maxHealth;
            set => maxHealth = Math.Max(0, value);
        }

        /// <summary>
        /// Probabilité de réussir un coup critique.
        /// La valeur est toujours comprise entre 0 et 1 (0% à 100%).
        /// </summary>
        public double CriticalHitChance
        {
            get => criticalHitChance;
            set => criticalHitChance = Math.Clamp(value, 0, 1);
        }
    }
}