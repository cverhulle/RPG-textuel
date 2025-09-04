using RPGTextuel.Config;
using RPGTextuel.Core.Characters;
using RPGTextuel.Items.Class;

namespace RPGTextuel.Core
{
    public class Player : Character
    {   // On ajoute au joueur une liste d'item. 
        // Par défaut, elle est vide.
        public Inventory Inventory { get; }

        // Les stats sont définis dans le fichier de configuration.
        // Le nom est laissé libre.
        public Player(string name) :
            base(
                name,
                GameStatConfig.playerHealthByDefault,
                GameStatConfig.playerAttackByDefault,
                GameStatConfig.playerHealthByDefault,
                GameStatConfig.criticalHitPlayer
                )
        {
            Inventory = new Inventory(this);
        }
    }
}