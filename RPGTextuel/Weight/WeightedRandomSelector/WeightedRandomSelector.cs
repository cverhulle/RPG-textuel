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
            // On teste la liste en entrée est valide.
            // Si ce n'est pas le cas, une erreur est retournée.
            WeightedRandomSelectorUtils.ValidateInput(objectsToDraw);

            // On récupère le poids total des objets.
            int totalWeight = WeightedRandomSelectorUtils.CalculateTotalWeight(objectsToDraw);

            // On "selectionne" aléatoirement un nombre entre 1 et le poids total.
            int roll = WeightedRandomSelectorUtils.GetRandomRoll(totalWeight);
            
            // On retourne l'objet choisi.
            return WeightedRandomSelectorUtils.PickObjectToDrawByRoll(objectsToDraw, roll);
        }

        // Méthode pour les items ayant un poids.
        public static Item SelectRandomItem(List<WeightedItem> items)
        {
            return SelectRandom(items.Select(wi => (wi.Item, wi.Weight)).ToList());
        }
    }
}