namespace RPGTextuel
{
    // Cette classe s'occupe de la sélection des ennemies.
    public static class EnemySelector
    {   
        private static readonly Random rng = new Random();

        // Cette méthode permet de choisir un ennemi aléatoire parmi la liste disponible.
        public static T PickRandom<T>(this List<T> list)
        {
            if (list == null || list.Count == 0)
                throw new ArgumentException("Liste vide");

            return list[rng.Next(list.Count)];
        }
    }
}