using RPGTextuel.Items.Class;

namespace RPGTextuel.WeightedRandomSelector
{
    // Cette classe permet de sélectionner aléatoirement un objet ayant un poids
    // de façon aléatoire.
    public static class WeightedRandomSelector
    {
        // Méthode générique pour tout type pondéré.
        public static T SelectRandom<T>(List<(T objectToDraw, int Weight)> objectsToDraw)
        {
            // Si la liste est vide, on retourne une erreur
            if (objectsToDraw == null || objectsToDraw.Count == 0)
                throw new ArgumentException("La liste ne peut pas être vide.");

            // On récupère le poids total des objets.
            int totalWeight =objectsToDraw.Sum(i => i.Weight);

            // On selectionne aléatoirement un nombre entre 1 et le poids total.
            int roll = Random.Shared.Next(1, totalWeight + 1);

            // On retourne l'objet choisi : 
            // En ajoutant les poids des divers objets successivement,
            // on cherche la première occurence qui dépasse le "roll".
            int cumulative = 0;
            foreach (var entry in objectsToDraw)
            {
                cumulative += entry.Weight;
                if (roll <= cumulative)
                    return entry.objectToDraw;
            }

            // En cas d'erreur, on retourne une erreur.
            throw new InvalidOperationException("Erreur dans la sélection pondérée.");
        }

        // Méthode pour les items ayant un poids.
        public static Item SelectRandomItem(List<WeightedItem> items)
        {
            return SelectRandom(items.Select(wi => (wi.Item, wi.Weight)).ToList());
        }
    }
}