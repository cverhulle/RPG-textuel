using RPGTextuel.Core;
using RPGTextuel.Core.Characters;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Items.Class;

namespace RPGTextuel.Game.GameFeatures.InventoryNamespace
{
    // Cette classe s'occupe des intéractions entre le joueur et son inventaire
    public static class InventoryInteraction

    {
        // Cette méthode retourne une liste de string contenant les objets de l'inventaire et un message de retour.
        public static List<string> GetItemNameListsAndBackMessage(List<Item> items, string backLabel = "Retour")
        {
            var names = items.Select(i => i.name).ToList();
            names.Add(backLabel);
            return names;
        }

        //------------------ TODO : A simplifier ---------------------------------
        // Cette méthode demande à l'utilisateur quel objet il souhaite utiliser.
        public static void PromptUseItem(Player player)
        {
            // On récupère l'inventaire du joueur.
            Inventory inventory = player.Inventory;

            // On gère le cas où l'inventaire est vide.
            if (inventory.IsEmpty())
            {
                GameUtils.WaitForUser("Votre inventaire est vide.");
                return;
            }

            // Crée la liste des noms d’objets et un message de retour.
            List<string> options = GetItemNameListsAndBackMessage(inventory.GetAllItems());

            // Appelle la fonction qui gère l'affichage et la réponse au menu.
            int choice = GameInputUser.AskMenuChoice(options, $"Inventaire de {player.Name}");

            // Si l’utilisateur a choisi "Retour" (dernier élément), on quitte.
            if (GameUtils.IsBackChoice(choice, options))
                return;

            // Sinon, on utilise l’objet correspondant (on n'oublie pas le décalage d'indice)
            inventory.UseItem(choice - 1, player);
            GameUtils.WaitForUser("Objet utilisé !");
        }

        // Cette méthode permet à l'utilisateur d'utiliser un objet à l'aide de son index
        // Elle affiche un message et attend qu'il tape sur le clavier pour continuer
        public static void UseItemAndWait(int index, Player player, Character target)
        {
            player.Inventory.UseItem(index, target);
            GameUtils.WaitForUser("Objet utilisé !");
        }
    }
}