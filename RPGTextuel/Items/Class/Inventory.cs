using RPGTextuel.Config;
using RPGTextuel.Core.Characters;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Items.Class
{
    /// <summary>
    /// Représente l'inventaire d'un personnage.
    /// Permet de stocker, afficher, utiliser et supprimer des objets.
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// Liste des objets contenus dans l'inventaire.
        /// </summary>
        private List<Item> items = new List<Item>();

        /// <summary>
        /// Référence vers le propriétaire de l'inventaire (joueur ou ennemi).
        /// </summary>
        private Character owner;

        /// <summary>
        /// Constructeur de la classe Inventory.
        /// </summary>
        /// <param name="inventoryOwner">Le personnage qui possède cet inventaire.</param>
        public Inventory(Character inventoryOwner)
        {
            owner = inventoryOwner;
        }

        /// <summary>
        /// Retourne le nombre d'objets présents dans l'inventaire.
        /// </summary>
        public int Count => items.Count;

        /// <summary>
        /// Ajoute un objet à l'inventaire.
        /// </summary>
        /// <param name="item">L'objet à ajouter.</param>
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        /// <summary>
        /// Affiche le contenu de l'inventaire.
        /// Si l'inventaire est vide, affiche un message spécifique.
        /// </summary>
        public void DisplayInventory()
        {
            // On regarde si l'inventaire est vide.
            if (IsEmpty())
            {
                // Si c'est le cas, on affiche un message personnalisé.
                GameUtils.WaitForUser("Votre inventaire est vide.", color: TextColorConfig.itemsColor);
                return;
            }

            // On appelle la méthode pour gérer l'affichage des options.
            GameDisplay.PrintFramedList(
                GetAllItems(),
                item => item.name,
                $"Inventaire de {owner.Name}",
                showCount: true
            );
        }

        /// <summary>
        /// Retourne la liste des objets de l'inventaire triée par type et par taille.
        /// </summary>
        public List<Item> GetAllItems()
        {
            return items
                .OrderBy(i =>
                {
                    // Priorité par type
                    if (i.name.Contains("soin", StringComparison.OrdinalIgnoreCase)) return 1;
                    if (i.name.Contains("dégats", StringComparison.OrdinalIgnoreCase)) return 2;
                    return 99; // autres objets en dernier
                })
                .ThenBy(i =>
                {
                    // Priorité par taille
                    if (i.name.Contains("petite", StringComparison.OrdinalIgnoreCase)) return 1;
                    if (i.name.Contains("moyenne", StringComparison.OrdinalIgnoreCase)) return 2;
                    if (i.name.Contains("grande", StringComparison.OrdinalIgnoreCase)) return 3;
                    return 99; // taille inconnue en dernier
                })
                .ToList();
        }

        /// <summary>
        /// Indique si l'inventaire est vide.
        /// </summary>
        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        /// <summary>
        /// Vérifie si un index d'objet est valide.
        /// </summary>
        /// <param name="index">L'index de l'objet dans la liste.</param>
        public bool IsValidItemIndex(int index)
        {
            return index >= 0 && index < items.Count;
        }

        /// <summary>
        /// Retourne la liste des noms des objets contenus dans l'inventaire.
        /// </summary>
        public List<string> GetItemNames()
        {
            return items.Select(i => i.name).ToList();
        }

        /// <summary>
        /// Supprime un objet de l'inventaire en fonction de son index.
        /// </summary>
        /// <param name="index">L'index de l'objet à supprimer.</param>
        public void RemoveItemByIndex(int index)
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

        /// <summary>
        /// Utilise un objet de l'inventaire puis le supprime s'il a bien été utilisé.
        /// </summary>
        /// <param name="index">L'index de l'objet à utiliser.</param>
        /// <param name="user">Le personnage qui utilise l'objet.</param>
        /// <param name="target">La cible de l'utilisation de l'objet.</param>
        /// <returns>True si l'objet a été utilisé et supprimé, False sinon.</returns>
        public Boolean UseItem(int index, Character user, Character target)
        {
            if (IsValidItemIndex(index))
            {
                Boolean isItemUsed = items[index].Use(user, target);
                if (isItemUsed)
                {
                    RemoveItemByIndex(index);
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