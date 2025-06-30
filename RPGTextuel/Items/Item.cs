namespace RPGTextuel.Items
{
    // On crée une classe abstraite appelée Item
    public abstract class Item
    {
        // On liste ses attributs
        public string Name { get; protected set; }

        // On implémente son constructeur.
        public Item(string name)
        {
            Name = name;
        }
    }
}