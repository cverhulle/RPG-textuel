namespace RPGTextuel.WeightedRandomSelector
{
    // Cette classe fournit une liste de méthodes utilitaires pour WeightedRandomSelector
    public static class WeightedRandomSelectorUtils
    {
        // Cette méthode permet de valider la liste d'objects en entrée.
        // Elle retourne une erreur si elle est vide ou null
        // On retourne une erreur si un poids est strictement négatif.
        public static void ValidateInput<T>(List<(T objectToDraw, int Weight)> ObjectsToDraw)
        {
            if (ObjectsToDraw == null || ObjectsToDraw.Count == 0)
                throw new ArgumentException("La liste ne peut pas être vide.");

            if (ObjectsToDraw.Any(i => i.Weight < 0))
                throw new ArgumentException("Tous les poids doivent être strictement positifs.");
        }

        // Cette méthode permet de calculer le poids total d'une liste d'objects avec des poids.
        public static int CalculateTotalWeight<T>(List<(T objectToDraw, int Weight)> ObjectsToDraw)
        {
            return ObjectsToDraw.Sum(i => i.Weight);
        }

        // Cette méthode permet de choisir aléatoirement un nombre entre 1 et le poids total
        public static int GetRandomRoll(int totalWeight)
        {
            return Random.Shared.Next(1, totalWeight + 1);
        }

        // On retourne l' "objet choisi" : 
        // En ajoutant les poids des divers objets successivement,
        // on cherche la première occurence qui dépasse le "roll".
        // On retourne une erreur s'il y a un problème.
        public static T PickObjectToDrawByRoll<T>(List<(T objectToDraw, int Weight)> ObjectsToDraw, int roll)
        {
            int cumulative = 0;
            foreach (var (ObjectToDraw, weight) in ObjectsToDraw)
            {
                cumulative += weight;
                if (roll <= cumulative)
                    return ObjectToDraw;
            }
            throw new InvalidOperationException("Erreur dans la sélection pondérée.");
        }
    }
}