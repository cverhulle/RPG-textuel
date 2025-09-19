using RPGTextuel.Config;
using RPGTextuel.Core.Characters;
using RPGTextuel.Items.Class;

namespace RPGTextuel.Items.Consumables
{
    /// <summary>
    /// Représente une potion de soin, un objet consommable qui restaure des points de vie à une cible.
    /// </summary>
    public class HealPotion : Item
    {
        /// <summary>
        /// Quantité de points de vie restaurés par la potion.
        /// </summary>
        public int healAmount { get; }

        /// <summary>
        /// Constructeur de la classe <see cref="HealPotion"/>.
        /// </summary>
        /// <param name="name">Nom de la potion.</param>
        /// <param name="healAmountOfPotion">Nombre de points de vie restaurés.</param>
        public HealPotion(string name, int healAmountOfPotion) : base(name)
        {
            healAmount = healAmountOfPotion;
        }

        /// <summary>
        /// Utilise la potion de soin sur une cible.
        /// </summary>
        /// <param name="user">Le personnage qui utilise la potion.</param>
        /// <param name="target">La cible de la potion.</param>
        /// <returns>
        /// True si la potion a été utilisée avec succès (soin appliqué), 
        /// False si le soin n’a pas pu être appliqué.
        /// </returns>
        public override Boolean Use(Character user, Character target)
        {
            // On modifie l'affichage en violet
            Console.ForegroundColor = TextColorConfig.itemsColor;

            Console.WriteLine($"{user.Name} utilise {name} sur {target.Name}");

            bool isHealed = target.Heal(healAmount);

            // On remet l'affichage par défaut.
            Console.ForegroundColor = TextColorConfig.defaultColor;

            return isHealed;
        }
    }
}