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
        // On retourne un booléen indiquant sur l'objet est utilisé ou non.
        public override Boolean Use(Character user, Character target)
        {
            // On modifie l'affichage en violet
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            // Si l'utilisateur est la cible, c'est une "erreur"
            if (user == target)
            {
                Console.WriteLine("Vous ne pouvez pas utiliser une potion de dégâts sur vous-même !");
                return false;
            }

            // Sinon, on diminue les PV de la cible
            Console.WriteLine($"{user.Name} utilise {name} sur {target.Name}");
            target.TakeDamage(damage);

            // On reset la couleur d'affichage.
            Console.ResetColor();

            return true;
        }
    }
}