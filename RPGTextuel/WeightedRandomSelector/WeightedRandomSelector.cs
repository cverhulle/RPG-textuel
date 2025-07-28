namespace RPGTextuel.WeightedRandomSelector
{
    // Cette classe permet de sélectionner aléatoirement un objet ayant un poids
    // de façon aléatoire.
    public static class WeightedRandomSelector
    {
        // Méthode générique pour tout type pondéré.
        public static T SelectRandom<T>(List<(T Item, int Weight)> items)
        {
            if (items == null || items.Count == 0)
                throw new ArgumentException("La liste ne peut pas être vide.");

            int totalWeight = items.Sum(i => i.Weight);
            int roll = Random.Shared.Next(1, totalWeight + 1);

            int cumulative = 0;
            foreach (var entry in items)
            {
                cumulative += entry.Weight;
                if (roll <= cumulative)
                    return entry.Item;
            }

            throw new InvalidOperationException("Erreur dans la sélection pondérée.");
        }
    }
}