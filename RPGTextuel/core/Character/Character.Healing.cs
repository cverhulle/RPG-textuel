namespace RPGTextuel.Core.Characters
{
    public abstract partial class Character
    {
        // Cette méthode indique si le Character peut recevoir des soins.
        public bool CanBeHealed(int amount)
        {
            return amount > 0 && Health < MaxHealth;
        }

        // Cette méthode permet de gérer le dépassement des points de vie max.
        protected void HandleExceedingLifePoints()
        {
            if (Health > MaxHealth)
                Health = MaxHealth;
        }

        // Cette méthode permet de gérer le calcul des soins.
        // Elle retourne le montnant de soin effectif.
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

        // Cette méthode permet de se soigner de "soin" PV.
        // On retourne true si le soin est effectué et false sinon.
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