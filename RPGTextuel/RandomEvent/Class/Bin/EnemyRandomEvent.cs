using RPGTextuel.Enemies.Class;

//////////////////////////////////
// ATTENTION : CLASSE NON UTILISEE 
//////////////////////////////////

namespace RPGTextuel.RandomEvent.Class
{
    /// <summary>
    /// Classe abstraite représentant un évènement aléatoire pouvant affecter un ennemi.
    /// Chaque évènement possède un nom, une description et une logique d'exécution.
    /// </summary>
    public abstract class EnemyRandomEventClass
    {
        /// <summary>
        /// Nom de l'évènement aléatoire.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Description détaillée de l'évènement.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Déclenche l'évènement sur l'ennemi passé en paramètre.
        /// </summary>
        /// <param name="enemy">L'ennemi ciblé par l'évènement.</param>
        public abstract void Trigger(Enemy enemy);
    }
}