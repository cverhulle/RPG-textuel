namespace RPGTextuel.Extensions.List
{
    /// <summary>
    /// Fournit des méthodes d'extension pour les listes génériques (<see cref="List{T}"/>).
    /// </summary>
    public static class ListExtensions
    {
        // On appelle la fonction Random pour faire un choix aléatoire.
        private static readonly Random rng = new Random();

        /// <summary>
        /// Retourne un élément choisi aléatoirement dans la liste.
        /// </summary>
        /// <typeparam name="T">Le type des éléments contenus dans la liste.</typeparam>
        /// <param name="list">La liste dans laquelle piocher un élément.</param>
        /// <returns>Un élément aléatoire de la liste.</returns>
        /// <exception cref="ArgumentNullException">Si la liste est <c>null</c>.</exception>
        /// <exception cref="InvalidOperationException">Si la liste est vide.</exception>
        public static T PickRandom<T>(this List<T> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list), "La liste ne peut pas être nulle.");

            if (list.Count == 0)
                throw new InvalidOperationException("Impossible de choisir un élément dans une liste vide.");

            return list[rng.Next(list.Count)];
        }
    }
}