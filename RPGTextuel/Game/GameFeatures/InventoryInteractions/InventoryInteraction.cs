using RPGTextuel.Core;
using RPGTextuel.Core.Characters;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Items.Class;

namespace RPGTextuel.Game.GameFeatures.InventoryNamespace
{
    // Cette classe s'occupe des intéractions entre le joueur et son inventaire
    public static class InventoryInteraction
    {
        // Cette méthode permet de choisir la cible de l'objet à utiliser.
        // On peut fournir un ennemi à la liste des cibles.
        // S'il n'y pas d'ennemis, la cible est le joueur.
        public static Character ChooseTarget(Character player, Character? enemy = null)
        {
            // Par défaut, il n'y a que le joueur dans la liste des cibles.
            var targets = new List<Character> { player };
            var options = new List<string> { $"{player.Name} (vous)" };

            // Si un ennemi est présent, on l'ajoute à la liste des cibles.
            if (enemy != null)
            {
                targets.Add(enemy);
                options.Add(enemy.Name);
            }

            // Si une seule cible possible (le joueur), on ne pose pas la question
            if (targets.Count == 1)
            {
                return player;
            }

            int choice = GameInputUser.AskMenuChoice(options, "Choisissez une cible");

            return targets[choice - 1];
        }

        // Cette méthode retourne une liste de string contenant les objets de l'inventaire et un message de retour.
        public static List<string> GetItemNameListsAndBackMessage(List<Item> items, string backLabel = "Retour")
        {
            var names = items.Select(i => i.name).ToList();
            names.Add(backLabel);
            return names;
        }

        // Cette méthode demande à l'utilisateur quel objet il souhaite utiliser.
        // Elle retourne le choix de l'utilisateur (retour si l'inventaire est vide).
        public static int PromptItem(Player player)
        {
             // On récupère l'inventaire du joueur.
            Inventory inventory = player.Inventory;

            // On gère le cas où l'inventaire est vide.
            if (inventory.IsEmpty())
            {
                GameUtils.WaitForUser("Votre inventaire est vide.");
                return inventory.Count +1;
            }

            // Crée la liste des noms d’objets et un message de retour.
            List<string> options = GetItemNameListsAndBackMessage(inventory.GetAllItems());

            // Appelle la fonction qui gère l'affichage et la réponse au menu.
            return GameInputUser.AskMenuChoice(options, $"Inventaire de {player.Name}");
        }

        // Cette méthode demande à l'utilisateur quel objet il souhaite utiliser.
        // Elle utilise ensuite l'item selectionné.
        // Elle retourne un booléan pour savoir si l'objet est utilisé ou non.
        public static Boolean PromptUseItem(Player player, Character enemy)
        {
            // Appelle la fonction qui gère l'affichage et la réponse au menu.
            int choice = PromptItem(player);

            // Si l’utilisateur a choisi "Retour" (dernier élément) ou que son inventaire est vide, on quitte.
            if (choice == player.Inventory.Count +1)
                return false;

            // Choix de la cible
            Character target = ChooseTarget(player, enemy);

            // Sinon, on utilise l’objet correspondant (on n'oublie pas le décalage d'indice)
            return UseItemAndWait(choice - 1, player, target);
        }

        // Cette méthode permet à l'utilisateur d'utiliser un objet à l'aide de son index.
        // Elle affiche un message et attend qu'il tape sur le clavier pour continuer.
        // Elle retourne un booléan pour savoir si l'objet est utilisé ou non.
        public static Boolean UseItemAndWait(int index, Player player, Character target)
        {
            Boolean isItemUsed = player.Inventory.UseItem(index, player, target);
            if (isItemUsed)
            {
                GameUtils.WaitForUser("Objet utilisé !");
            }
            else
            {
                GameUtils.WaitForUser("L'objet n'a pas pu être utilisé.");
            }
            return isItemUsed;
        }
    }
}