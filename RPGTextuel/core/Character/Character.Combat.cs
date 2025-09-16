using RPGTextuel.Config;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Utils;

namespace RPGTextuel.Core.Characters
{
    public abstract partial class Character
    {
        /// <summary>
        /// Réduit les points de vie du personnage en fonction des dégâts reçus.
        /// </summary>
        /// <param name="hit">Le nombre de points de dégâts subis.</param>
        /// <remarks>
        /// La valeur des points de vie est automatiquement bornée à un minimum de 0.
        /// Un message est affiché dans la console pour indiquer les dégâts reçus.
        /// </remarks>
        public virtual void TakeDamage(int hit)
        {
            Health -= hit;
            Console.WriteLine($"{Name} subit {hit} points de dégâts. PV restants : {Health}");
        }

        // Cette méthode permet d'infliger des dégats à un autre Character.
        public virtual void Attack(Character target)
        {
            // On tire aléatoirement un nombre pour savoir si l'attaque est critique ou non.
            bool isCritical = Random.Shared.NextDouble() <= CriticalHitChance;

            // On récupère les dégats du joueur
            int damage = Strength;

            // Si l'attaque est critique...
            if (isCritical)
            {
                // On augmente les dégats.
                damage = (int)Math.Round(damage * GameStatConfig.criticalMultiplicator);

                // On gère l'affichage
                DisplayUtils.WriteLineInColor($"{Name} réussit un COUP CRITIQUE sur {target.Name} infligeant {damage} dégâts !", TextColorConfig.critColor);
            }
            // Sinon, on gère simplement l'affichage.
            else
            {
                Console.WriteLine($"{Name} attaque {target.Name} pour {damage} points de dégâts.");
            }

            // On modifie la couleur du texte 
            if (this is Player)
                Console.ForegroundColor = TextColorConfig.playerColor;
            else if (this is Enemy)
                Console.ForegroundColor = TextColorConfig.ennemiesColor;

            // Dans les deux cas, on inflige les dégats à la cible
            target.TakeDamage(damage);

            // On remet la couleur par défaut
            Console.ForegroundColor = TextColorConfig.defaultColor;
        }
    }
}