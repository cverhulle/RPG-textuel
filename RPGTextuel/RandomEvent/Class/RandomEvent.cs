using RPGTextuel.Core;

namespace RPGTextuel.RandomEvent.Class
{
    // Cette classe définit la structure d'un évenement aléatoire.
    public abstract class PlayerRandomEventClass
    {
        // On crée deux attributs "Name" et "Description"
        public abstract string Name { get; }
        public abstract string Description { get; }

        // On implémente la méthode Trigger pour déclencher l'évenement.
        public abstract void Trigger(Player player);
    }
}