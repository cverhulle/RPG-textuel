using RPGTextuel.Core.Characters;
using RPGTextuel.Items.Class;

namespace RPGTextuel.Items.Consumables
{
    // On crée la classe qui s'occupe de la potion de dégats.
    public class DamagePotion : Item
    {
        // On définit son attribut.
        public int damage { get; }

        // On implémente le constructeur de cette classe.
        public DamagePotion(string name, int damagePotion) : base(name)
        {
            damage = damagePotion;
        }

        // On implémente la méthode Use.
        // Elle prend en argument un personnage et lui enlève des PV égaux à damage.
        public override Boolean Use(Character target)
        {
            Console.WriteLine($"{target.Name} est touché par {name}");
            target.TakeDamage(damage);
            return true;
        }
    }
}