using RPGTextuel.Core.Characters;
using RPGTextuel.Items.Class;

namespace RPGTextuel.Items.Consumables
{
    // Création de l'objet Potion de soin
    public class HealPotion : Item
    {
        // On liste ses attributs
        public int healAmount { get; }

        // On définiti son constructeur
        public HealPotion(string name, int healAmountOfPotion) : base(name)
        {
            healAmount = healAmountOfPotion;
        }

        // Cette méthode permet d'utiliser la potion de soin.
        // Elle régénère un certain montant de PV.
        public override Boolean Use(Character user, Character target)
        {
            Console.WriteLine($"{user.Name} utilise {name} sur {target.Name}");
            return target.Heal(healAmount);
        }
    }
}