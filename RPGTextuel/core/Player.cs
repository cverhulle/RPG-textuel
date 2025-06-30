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

    // Cette méthode permet d'afficher les items du joueur
    public void DisplayInventory()
    {
        // Si l'inventaire est vide, on affiche un message personnalisé
        if (Inventory.Count == 0)
        {
            Console.WriteLine($"{Name} n'a pas d'objets");
            return;
        }

        // Sinon, on affiche la liste de sobjets du personnage.
        Console.WriteLine($"\n Inventaire de {Name}");

        for (int i = 0; i < Inventory.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {Inventory[i].name}");
        }
    }
    
    // Cette méthode permet de retirer un objet
    public void RemoveItem(int index)
    {
        if (IsValidItemIndex(index))
        {
            Inventory.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Erreur lors de la suppression de l'objet.");
        }
    }
}