using RPGTextuel.Items;

namespace RPGTextuel
{
    // On crée la classe "Inventaire"
    public class Inventory
    {
        // Cette classe contient une liste d'objet.
        private List<Item> items = new List<Item>();

        // On crée un raccourci pour récupérer le nombre d'objets.
        public int Count
        {
            get => items.Count;
        }

    }    
}