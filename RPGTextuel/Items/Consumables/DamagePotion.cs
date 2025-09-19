using RPGTextuel.Config;
using RPGTextuel.Core.Characters;
using RPGTextuel.Items.Class;

namespace RPGTextuel.Items.Consumables
{
    /// <summary>
    /// Représente une potion de dégâts, un objet consommable qui inflige des points de dégâts à une cible.
    /// </summary>
    public class DamagePotion : Item
    {
        /// <summary>
        /// Quantité de dégâts infligés par la potion.
        /// </summary>
        public int damage { get; }

        /// <summary>
        /// Constructeur de la classe <see cref="DamagePotion"/>.
        /// </summary>
        /// <param name="name">Nom de la potion.</param>
        /// <param name="damagePotion">Nombre de points de dégâts infligés.</param>
        public DamagePotion(string name, int damagePotion) : base(name)
        {
            damage = damagePotion;
        }

        /// <summary>
        /// Utilise la potion de dégâts sur une cible.
        /// </summary>
        /// <param name="user">Le personnage qui utilise la potion.</param>
        /// <param name="target">La cible de la potion.</param>
        /// <returns>
        /// True si la potion a été utilisée avec succès, False si l’action est invalide 
        /// (par exemple, si l’utilisateur tente de l’utiliser sur lui-même).
        /// </returns>
        public override Boolean Use(Character user, Character target)
        {
            // On modifie l'affichage en violet
            Console.ForegroundColor = TextColorConfig.itemsColor;

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
            Console.ForegroundColor = TextColorConfig.defaultColor;

            return true;
        }
    }
}