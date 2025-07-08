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
        public override Boolean Use(Character user, Character target)
        {
            if (user == target)
            {
                Console.WriteLine("Vous ne pouvez pas utiliser une potion de dégâts sur vous-même !");
                return false; 
            }

            Console.WriteLine($"{user.Name} utilise {name} sur {target.Name}");
            target.TakeDamage(damage);
            return true;
        }
    }
}