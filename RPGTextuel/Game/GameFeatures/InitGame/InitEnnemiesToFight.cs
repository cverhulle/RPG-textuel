using RPGTextuel.Enemies.Class;
using RPGTextuel.SetupEnemies;

namespace RPGTextuel.Game.GameFeatures.InitPlayer
{
    // Cette classe s'occupe de créer une liste contenant les ennemis que le jouer
    // affrontera pendant cette partie.
    public static class InitEnnemiesToFight
    {
        // Cette méthode retourne une liste d'ennemis, choisis au hasard.
        // Pour le moment, on choisit un gobelin de chaque type.
        public static List<Enemy> GetRandomGoblinSet()
        {
            return new List<Enemy>
                {
                    SetupGoblinMinions.GetRandomGoblinMinion(),
                    SetupGoblins.GetRandomGoblin(),
                    SetupGoblinChiefs.GetRandomGoblinChief()
                };
        }        
    }
}