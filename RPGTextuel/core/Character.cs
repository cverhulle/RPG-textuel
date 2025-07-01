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

        // Cette méthode permet d'encaisser des dégats.
        // Elle prend en argument un entier "dégats" et diminue la vie du Character de ce nombre.
        public virtual void TakeDamage(int hit)
        {
            Health -= hit;
            Console.WriteLine($"{Name} subit {hit} points de dégâts. PV restants : {Health}");
        }

        // Cette méthode permet d'infliger des dégats à un autre Character.
        public virtual void Attack(Character target)
        {
            Console.WriteLine($"{Name} attaque {target.Name} pour {Strength} points de dégâts !");
            target.TakeDamage(Strength);
        }

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
        public virtual void Heal(int amount)
        {
            // On vérfie que le Character peut recevoir des soins
            if (!CanBeHealed(amount))
            {
                // Si ce n'est pas le cas, on affiche un message et, on ne fait rien.
                Console.WriteLine($"{Name} ne peut pas être soigné avec {amount} PV.");
                return;
            }

            // On applique les soins, et, on affiche un message d'information à l'utilisateur.
            int actualHealed = ApplyHeal(amount);
            Console.WriteLine($"{Name} récupère {actualHealed} points de vie. PV actuels : {Health}");
        }
    }
}