namespace RPGTextuel.Core.PlayerNamespace
{
    // Cette classe fournit des méthodes utilitaires pour modifier les stats des personnages.
    public static class ModifyStatHelper
    {
        // Cette méthode permet de modifier les stats d'un joueur selon des bornes.
        public static double ModifyStatWithBounds
        (
            double stat,                        // Stat à modifier
            double min,                         // Valeur minimale pour la stat
            double max,                         // Valeur maximale pour la stat
            double randomMinChange,             // Valeur minimale pour le changement à effectuer
            double randomMaxChange,             // Valeur minimale pour le changement à effectuer
            bool increase,                      // Augmentation : true ; Diminution : false
            string alreadyAtBoundMessage,       // Si la stat est déjà au maximum ou au minimum, on personnalise le message
            string changeMessageTemplate,       // Message d'information pour l'utilisateur indiquant la valeur de la modif.
            string finalValueMessageTemplate,   // Message indiquant la nouvelle valeur de la stat pour l'utilisateur.    
            bool isPercentage = true,           // Définit si la stat est exprimée en % ou non 
            bool roundToInt = false             // Indique si on arrondit en entier
        )
        {
            // On regarde si la stat à modifier est déjà au maximum ou au minimum.
            if ((increase && stat >= max) || (!increase && stat <= min))
            {
                Console.WriteLine(alreadyAtBoundMessage);
                return stat;
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

            // Si besoin, on force en entier
            if (roundToInt)
            {
                change = Math.Round(change); // on affiche le gain comme entier
                stat = Math.Round(stat);     // on garde la stat comme entier
            }

            // Format d’affichage : % ou valeur brute
            if (isPercentage)
            {
                Console.WriteLine(string.Format(changeMessageTemplate, change * 100));
                Console.WriteLine(string.Format(finalValueMessageTemplate, stat * 100));
            }
            else
            {
                Console.WriteLine(string.Format(changeMessageTemplate, change));
                Console.WriteLine(string.Format(finalValueMessageTemplate, stat));
            }

            return stat;
        }
    }
}