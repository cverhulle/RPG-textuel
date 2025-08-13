namespace RPGTextuel.Core.Characters
{
    public abstract partial class Character
    {
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
            bool isCritical = Random.Shared.NextDouble() <= CriticalHitChance;
            int damage = Strength;

            if (isCritical)
            {
                damage = (int)(damage * 2); // Double les dégâts
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{Name} réussit un COUP CRITIQUE sur {target.Name} infligeant {damage} dégâts !");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{Name} attaque {target.Name} pour {damage} points de dégâts.");
            }

            target.TakeDamage(damage);


        }
    }
}