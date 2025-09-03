using RPGTextuel.Config;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Utils;

namespace RPGTextuel.Core.Characters
{
    public abstract partial class Character
    {
        // Cette méthode permet d'encaisser des dégats.
        // Elle prend en argument un entier "dégats" et diminue la vie du Character de ce nombre.
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