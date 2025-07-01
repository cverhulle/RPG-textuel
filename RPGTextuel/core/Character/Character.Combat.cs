namespace RPGTextuel
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
            Console.WriteLine($"{Name} attaque {target.Name} pour {Strength} points de dégâts !");
            target.TakeDamage(Strength);
        }
    }
}