namespace RPGTextuel.Core.Player
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
            // Déjà au maximum ou minimum
            if ((increase && stat >= max) || (!increase && stat <= min))
            {
                Console.WriteLine(alreadyAtBoundMessage);
                return;
            }

            // Changement aléatoire
            double change = Random.Shared.NextDouble() * (randomMaxChange - randomMinChange) + randomMinChange;

            // Calcul de la marge disponible
            double availableChange = increase ? (max - stat) : (stat - min);

            // Limiter le changement si besoin
            if (change > availableChange)
                change = availableChange;

            // Appliquer le changement
            stat += increase ? change : -change;

            // Messages
            Console.WriteLine(string.Format(changeMessageTemplate, change * 100));
            Console.WriteLine(string.Format(finalValueMessageTemplate, stat * 100));
        }
    }
}