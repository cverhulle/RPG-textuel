using RPGTextuel.Config;

namespace RPGTextuel.Game
{
    // Cette classe s'occupe de gérer les méthodes utilitaires.
    public static class GameUtils
    {
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
    }
}