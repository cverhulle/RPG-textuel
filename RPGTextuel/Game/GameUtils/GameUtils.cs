using RPGTextuel.Config;

namespace RPGTextuel.Game.GameUtilsNamespace
{
    // Cette classe s'occupe de gérer les méthodes utilitaires.
    public static class GameUtils
    {
        // Cette méthode vérifie si un nom, donné en paramètre, est null ou vide.
        public static Boolean IsNameNullOrWhiteSpace(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Cette méthode vérifie si un nom, donné en paramètre, est trop long ou pas.
        public static Boolean IsNameTooLong(string name)
        {
            if (name.Length > GameConfig.MaxNameLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Cette méthode permet de vérifier que la réponse à un menu est valide.
        // Une réponse est valide si elle est située entre 1 et le  maximum d'options disponibles.
        public static bool IsValidMenuChoice(string input, int maxOptionCount, out int choice)
        {
            return int.TryParse(input, out choice) &&
                choice >= 1 &&
                choice <= maxOptionCount;
        }
    }
}