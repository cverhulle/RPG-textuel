namespace RPGTextuel.Core.PlayerNamespace
{
    // Cette classe fournit des méthodes utilitaires liées aux Player.
    public static class PlayerStatHelper
    {
        // Cette méthode permet de modifier les stats d'un joueur selon des bornes.
        public static void ModifyStatWithBounds
        (
            ref double stat,
            double min,
            double max,
            double randomMinChange,
            double randomMaxChange,
            bool increase,
            string alreadyAtBoundMessage,
            string changeMessageTemplate,
            string finalValueMessageTemplate
        )
        {
            // On regarde si la stat à modifier est déjà au maximum ou au minimum.
            if ((increase && stat >= max) || (!increase && stat <= min))
            {
                Console.WriteLine(alreadyAtBoundMessage);
                return;
            }

            // On calcule la valeur du changement
            double change = Random.Shared.NextDouble() * (randomMaxChange - randomMinChange) + randomMinChange;

            // On Calcule de la marge disponible
            double availableChange = increase ? (max - stat) : (stat - min);

            // On Limite le changement si besoin
            if (change > availableChange)
                change = availableChange;

            // On modifie la statistique
            stat += increase ? change : -change;

            // Messages d'informations pour l'utilisateur.
            Console.WriteLine(string.Format(changeMessageTemplate, change * 100));
            Console.WriteLine(string.Format(finalValueMessageTemplate, stat * 100));
        }
    }
}