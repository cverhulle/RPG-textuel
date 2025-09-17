namespace RPGTextuel.Core.Characters
{
    public abstract partial class Character
    {
        /// <summary>
        /// Vérifie si le personnage peut recevoir un soin donné.
        /// </summary>
        /// <param name="amount">Montant de points de vie à restaurer.</param>
        /// <returns>
        /// <c>true</c> si <paramref name="amount"/> est positif et que
        /// <see cref="Health"/> est inférieur à <see cref="MaxHealth"/> ;
        /// sinon <c>false</c>.
        /// </returns>
        public bool CanBeHealed(int amount)
        {
            return amount > 0 && Health < MaxHealth;
        }

        /// <summary>
        /// S'assure que les points de vie n'excèdent pas <see cref="MaxHealth"/>.
        /// </summary>
        protected void HandleExceedingLifePoints()
        {
            if (Health > MaxHealth)
                Health = MaxHealth;
        }

        /// <summary>
        /// Applique un soin et retourne le montant réellement restauré.
        /// </summary>
        /// <param name="amount">Montant de points de vie à restaurer.</param>
        /// <returns>Nombre de PV effectivement restaurés.</returns>
        protected int ApplyHeal(int amount)
        {
            // On mémorise l'ancien nombre de PV.
            int oldHealth = Health;

            // On augmente la vie du Character
            Health += amount;

            // On gère le dépassement des points de vie max.
            this.HandleExceedingLifePoints();

            // On calcule les soins effectifs et, on retourne cette valeur.
            return Health - oldHealth;
        }

        /// <summary>
        /// Tente de soigner le personnage.
        /// </summary>
        /// <param name="amount">Montant de points de vie à restaurer.</param>
        /// <returns>
        /// <c>true</c> si le soin a été appliqué avec succès, sinon <c>false</c>.
        /// </returns>
        public virtual Boolean Heal(int amount)
        {
            // On vérfie que le Character peut recevoir des soins
            if (!CanBeHealed(amount))
            {
                // Si ce n'est pas le cas, on affiche un message et, on ne fait rien.
                Console.WriteLine($"{Name} possède déjà tous ses PV.");
                return false;
            }

            // On applique les soins, et, on affiche un message d'information à l'utilisateur.
            int actualHealed = ApplyHeal(amount);
            Console.WriteLine($"{Name} récupère {actualHealed} points de vie. PV actuels : {Health}");
            return true;
        }
    }
}