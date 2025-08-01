using System.Runtime.Serialization;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Weight;
using RPGTextuel.Weight.Class;

namespace RPGTextuel.Test.Weight
{
    // Cette classe permet de tester WeightedRandomSelector
    public static class TestWeightedRandomSelector
    {
        // Cette méthode permet de tester SelectRandom
        public static void TestSelectRandom()
        {
            // On définit la liste des objets et leur poids.
            var options = new List<Weighted<string>>
            {
                new Weighted<string>("Pomme", 80),
                new Weighted<string>("Poire", 50),
                new Weighted<string>("Banane", 10)
            };

            // On calcule le poids total de l'ensemble des éléments.
            int totalWeight = options.Sum(o => o.Weight);

            // On construit un dictionnaire pour stocker les résultats.
            var results = new Dictionary<string, int>
            {
                { "Pomme", 0 },
                { "Poire", 0 },
                { "Banane", 0 }
            };

            // On tire aléatoirement un objet aléatoirement.
            // On compte la fréquence d'apparition de chaque élément dans le dictionnaire.
            int iterations = 10_000;
            for (int i = 0; i < iterations; i++)
            {
                string result = WeightedRandomSelector.SelectRandom(options);
                results[result]++;
            }

            // On affiche le résultat sous forme de pourcentages
            Console.WriteLine("Résultats après 10 000 tirages :");
            foreach (var kvp in results)
            {
                // On calcule le pourcentae obtenu par les tirages
                int actual = kvp.Value;
                double actualPercent = actual * 100.0 / iterations;

                // On calcule le pourcentage attendu
                int expectedWeight = options.First(o => o.Value == kvp.Key).Weight;
                double expectedPercent = expectedWeight * 100.0 / totalWeight;

                Console.WriteLine($"{kvp.Key} : {actual} tirages ({actualPercent:0.00}%)");
                Console.WriteLine($"  ➜ Probabilité attendue : {expectedWeight}/{totalWeight} ({expectedPercent:0.00}%)\n");
            }
            GameUtils.WaitForUser();
        }
    }
}