using RPGTextuel.Core.Characters;

namespace RPGTextuel.Items.Class
{
    /// <summary>
    /// Classe abstraite représentant un objet générique du jeu.
    /// Tous les objets héritant de cette classe doivent définir leur propre logique d'utilisation.
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// Nom de l'objet.
        /// </summary>
        public string name { get; protected set; }

        /// <summary>
        /// Constructeur de la classe Item.
        /// </summary>
        /// <param name="nameItem">Le nom de l'objet.</param>
        public Item(string nameItem)
        {
            name = nameItem;
        }

        /// <summary>
        /// Méthode abstraite permettant d'utiliser l'objet.
        /// Doit être implémentée par les classes dérivées.
        /// </summary>
        /// <param name="user">Le personnage qui utilise l'objet.</param>
        /// <param name="target">La cible sur laquelle l'objet est utilisé.</param>
        /// <returns>True si l'objet a été utilisé, False sinon.</returns>
        public abstract Boolean Use(Character user, Character target);
    }
}