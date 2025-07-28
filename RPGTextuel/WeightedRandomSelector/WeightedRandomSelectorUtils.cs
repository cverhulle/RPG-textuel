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
    }
}