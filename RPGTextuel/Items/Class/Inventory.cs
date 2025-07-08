using RPGTextuel.Core.Characters;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Items.Class
{
    // On crée la classe "Inventaire"
    public class Inventory
    {
        // Cette classe contient une liste d'objet et le nom de son propriétaire.
        private List<Item> items = new List<Item>();
        private Character owner;

        // On définit le constructeur de la classe.
        public Inventory(Character inventoryOwner)
        {
            owner = inventoryOwner;
        }

        // Cette méthode permet d'ajouter un item dans l'inventaire.
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        // Cette méthode permet d'afficher les items du joueur
        public void DisplayInventory()
        {
            // On regarde si l'inventaire est vide.
            if (IsEmpty())
            {
                // Si c'est le cas, on affiche un message personnalisé.
                Console.WriteLine($"{owner.Name} n'a pas d'objet");
                return;
            }

            // On appelle la méthode pour gérer l'affichage des options.
            GameDisplay.PrintFramedList(
                items,
                item => item.name,
                $"Inventaire de {owner.Name}",
                showCount: true
            );
        }

        // Cette méthode retourne tous les items dans l'inventaire.
        public List<Item> GetAllItems()
        {
            return items;
        }

        // Cette méthode retourne true si l'inventaire est vide et false sinon.
        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        // Cette méthode vérifie si l'index passé en argument est valide.
        public bool IsValidItemIndex(int index)
        {
            return index >= 0 && index < items.Count;
        }

        // Cette méthode retourne le nom de tous les items dans l'inventaire sous forme de liste.
        public List<string> GetItemNames()
        {
            return items.Select(i => i.name).ToList();
        }

        // Cette méthode permet de retirer un objet
        public void RemoveItem(int index)
        {
            if (IsValidItemIndex(index))
            {
                items.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Erreur lors de la suppression de l'objet.");
            }
        }

        // Cette méthode permet d'utiliser un item et de le supprimer après utilisation.
        // Si l'item ne peut pas être utilisé, on ne fait rien.
        // On retourne true si l'item est utilisé ; false sinon.
        public Boolean UseItem(int index, Character user, Character target)
        {
            if (IsValidItemIndex(index))
            {
                Boolean isItemUsed = items[index].Use(user, target);
                if (isItemUsed)
                {
                    RemoveItem(index);
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Item introuvable");
            }
            return false;
        }
    }
}