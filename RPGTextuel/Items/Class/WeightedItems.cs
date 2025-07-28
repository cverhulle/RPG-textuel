namespace RPGTextuel.Items.Class
{
    // Cette classe permet de donner du poids aux objets.
    // Elle gère leur taux d'obtention lors des évenements.
    public class WeightedItem
    {
        public Item Item { get; }
        public int Weight { get; }

        public WeightedItem(Item item, int weight)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
            Weight = weight > 0 ? weight : throw new ArgumentException("Le poids doit être strictement positif.");
        }
    }
}