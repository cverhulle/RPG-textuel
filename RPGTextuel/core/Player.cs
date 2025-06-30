using RPGTextuel.Items;
public class Player : Character
{   // On ajoute au joueur une liste d'item. 
    // Par défaut, elle est vide.
    public List<Item> Inventory { get; } = new List<Item>();

    // On définit un Player comme un Character à 100PV, 10 de force, 100PV max et dont le nom est laissé libre.
    public Player(string name) : base(name, 100, 10, 100)
    {
    }

    // Cette méthode permet d'ajouter un item dans l'inventaire.
    public void AddItem(Item item)
    {
        Inventory.Add(item);
        Console.WriteLine($"{Name} reçoit {item.name}.");
    }

    // Cette méthode permet d'utiliser un item.
    public void UseItem(int index, Character target)
    {
        if (IsValidItemIndex(index))
        {
            Item item = Inventory[index];
            item.Use(target);
            Inventory.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Item introuvable");
        }
    }

    // Cette méthode vérifie si l'index passé en argument est valide.
    public bool IsValidItemIndex(int index)
    {
        return index >= 0 && index < Inventory.Count;
    }
}