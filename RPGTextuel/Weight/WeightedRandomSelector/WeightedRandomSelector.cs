using RPGTextuel.Items.Class;
using RPGTextuel.Weight.Class;

namespace RPGTextuel.Weight
{
    // Cette classe permet de sélectionner aléatoirement un objet ayant un poids
    // de façon aléatoire.
    public static class WeightedRandomSelector
    {
        // Méthode générique pour tout type pondéré.
        public static T SelectRandom<T>(List<Weighted<T>> weightedObjects)
        {
            // On teste la liste en entrée est valide.
            // Si ce n'est pas le cas, une erreur est retournée.
            WeightedRandomSelectorUtils.ValidateInput(weightedObjects);

            // On récupère le poids total des objets.
            int totalWeight = WeightedRandomSelectorUtils.CalculateTotalWeight(weightedObjects);

            // On "selectionne" aléatoirement un nombre entre 1 et le poids total.
            int roll = WeightedRandomSelectorUtils.GetRandomRoll(totalWeight);
            
            // On retourne l'objet choisi.
            return WeightedRandomSelectorUtils.PickObjectToDrawByRoll(weightedObjects, roll);
        }

        // Méthode pour les items ayant un poids.
        public static Item SelectRandomItem(List<Weighted<Item>> items)
        {
            return SelectRandom(items);
        }
    }
}