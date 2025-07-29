namespace RPGTextuel.Weight.Class
{
    // Cette classe permet de donner du poids à un élément.
    // Elle gère leur taux d'obtention lors des évenements.
    public class Weighted<T>
    {
        public T Value { get; }
        public int Weight { get; }

        public Weighted(T value, int weight)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
            Weight = weight > 0 ? weight : throw new ArgumentException("Le poids doit être strictement positif.");
        }
    }
}