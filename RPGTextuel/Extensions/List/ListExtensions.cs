namespace RPGTextuel.Extensions.List
{
    // Cette classe s'occupe de gérer les extensions des listes.
    public static class ListExtensions
    {
        // On appelle la fonction Random pour faire un choix aléatoire.
        private static readonly Random rng = new Random();

        // Cette méthode choisit un élément aléatoire dans une liste.
        public static T PickRandom<T>(this List<T> list)
        {
            if (list == null || list.Count == 0)
                throw new ArgumentException("La liste est vide ou nulle.");

            return list[rng.Next(list.Count)];
        }
    }
}