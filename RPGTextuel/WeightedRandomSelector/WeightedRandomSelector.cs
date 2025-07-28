namespace RPGTextuel.WeightedRandomSelector
{
    // Cette classe permet de sélectionner aléatoirement un objet ayant un poids
    // de façon aléatoire.
    public static class WeightedRandomSelector
    {
        // Méthode générique pour tout type pondéré.
        public static T SelectRandom<T>(List<(T Item, int Weight)> items)
        {
            // Si la liste est vide, on retourne une erreur
            if (items == null || items.Count == 0)
                throw new ArgumentException("La liste ne peut pas être vide.");

            // On récupère le poids total des objets.
            int totalWeight = items.Sum(i => i.Weight);

            // On selectionne aléatoirement un nombre entre 1 et le poids total.
            int roll = Random.Shared.Next(1, totalWeight + 1);

            // On retourne l'objet choisi : 
            // En ajoutant les poids des divers objets successivement,
            // on cherche la première occurence qui dépasse le "roll".
            int cumulative = 0;
            foreach (var entry in items)
            {
                cumulative += entry.Weight;
                if (roll <= cumulative)
                    return entry.Item;
            }

            // En cas d'erreur, on retourne une erreur.
            throw new InvalidOperationException("Erreur dans la sélection pondérée.");
        }
    }
}