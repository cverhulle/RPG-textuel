namespace RPGTextuel.Items
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
        public override void Use(Character target)
        {
            Console.WriteLine($"{target.Name} utilise {name}");
            target.Heal(healAmount);
        }
    }
}