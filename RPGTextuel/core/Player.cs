using RPGTextuel.Core.Characters;
using RPGTextuel.Items.Class;

namespace RPGTextuel.Core
{
    public class Player : Character
    {   // On ajoute au joueur une liste d'item. 
        // Par défaut, elle est vide.
        public Inventory Inventory { get; }

        // On définit un Player comme un Character à 100PV, 10 de force, 100PV max, 15% de chances de critique et dont le nom est laissé libre.
        public Player(string name) : base(name, 100, 10, 100, 0.15)
        {
            Inventory = new Inventory(this);
        }
    }
}