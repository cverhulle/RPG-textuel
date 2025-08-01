namespace RPGTextuel.Game.GameFeatures.FightingAnEnemyMenus
{
    // Cette classe regroupe les méthodes utilitaires liées à FightingAnEnemyMenu
    public class FightingAnEnemyMenuUtils
    {
        // Cette méthode se déclenche lorsque l'utilisateur choisit l'option "Tenter un événement"
        // Cependant, il a déjà utilisé sa chance pour ce combat.
        public static void ChooseRandomEventButAlreadyTried()
        {
            Console.WriteLine("Vous avez déjà tenté votre chance pour cet affrontement !");
        }
    }
}
    