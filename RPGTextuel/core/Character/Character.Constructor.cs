using RPGTextuel.Config;

namespace RPGTextuel.Core.Characters
{
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Character"/>.
        /// </summary>
        /// <param name="characterName">Nom du personnage.</param>
        /// <param name="characterHealth">Points de vie initiaux.</param>
        /// <param name="characterStrength">Force d’attaque initiale.</param>
        /// <param name="characterMaxHealth">Points de vie maximum autorisés.</param>
        /// <param name="criticalHitChance"> Probabilité de coup critique.  
        /// Par défaut, utilise <see cref="GameStatConfig.CriticalHitByDefault"/>.
        /// </param>
    public abstract partial class Character
    {
        protected Character
        (
            string characterName,
            int characterHealth,
            int characterStrength,
            int characterMaxHealth,
            double criticalHitChance = GameStatConfig.criticalHitByDefault
        )
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