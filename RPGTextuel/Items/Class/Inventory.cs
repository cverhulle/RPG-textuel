using RPGTextuel.Core.Characters;

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

        // Cette méthode permet d'utiliser un item.
        public void UseItem(int index, Character target)
        {
            if (IsValidItemIndex(index))
            {
                items[index].Use(target);
                RemoveItem(index);
            }
            else
            {
                Console.WriteLine("Item introuvable");
            }
        }

        // Cette méthode vérifie si l'index passé en argument est valide.
        public bool IsValidItemIndex(int index)
        {
            return index >= 0 && index < items.Count;
        }

        // Cette méthode permet d'afficher les items du joueur
        public void DisplayInventory()
        {
            // Si l'inventaire est vide, on affiche un message personnalisé
            if (items.Count == 0)
            {
                Console.WriteLine($"{owner.Name} n'a pas d'objet");
                return;
            }

            // Variable pour le titre de l'inventaire
            string titleInventory = $"===== INVENTAIRE DE {owner.Name.ToUpper()} =====";

            // Sinon, on affiche la liste des objets du personnage.
            Console.WriteLine(titleInventory);
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {items[i].name}");
            }

            // On affiche une liste de "=" en bas de l'inventaire.
            int backlineLength = titleInventory.Length;
            Console.WriteLine(new string('=', backlineLength));
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
    }
}