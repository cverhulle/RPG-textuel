using RPGTextuel.Core;

namespace RPGTextuel.Event.Class
{
    // Cette classe définit la structure d'un évenemnt aléatoire.
    public abstract class RandomEvent
    {
        // On crée deux attributs "Name" et "Description"
        public abstract string Name { get; }
        public abstract string Description { get; }

        // On implémente la méthode Trigger pour déclencher l'évenement.
        public abstract void Trigger(Player player);
    }
}