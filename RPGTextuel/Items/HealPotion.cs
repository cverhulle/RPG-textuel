namespace RPGTextuel.Items
{
    // Création de l'objet Potion de soin
    public class HealPotion : Item
    {   
        // On liste ses attributs
        public int HealAmount { get; }

        // On définiti son constructeur
        public HealPotion(string name, int healAmount) : base(name)
        {
            HealAmount = healAmount;
        }

        // Cette méthode permet d'utiliser la potion de soin.
        // Elle régénère un certain montant de PV.
        public override void Use(Character target)
        {
            Console.WriteLine($"{target.Name} utilise {Name}");
            target.Heal(HealAmount);
        }
    }
}