using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.RandomEvent.Class.Interface;
using RPGTextuel.Utils;
namespace RPGTextuel.RandomEvent.SetupEvent
{
    // On définit l'événement "Gain de chance de critique pour le prochain ennemi
    public class GainCritEnemyEvent : IRandomEvent
    {
        // On définit son nom et sa description.
        public string Name => "Un adversaire vicieux";
        public string Description => "Le prochain adversaire sait exploiter la moindre faille...";

        // On définit l'activation de l'événement.
        public void Trigger(Player? player = null, Enemy? enemy = null)
        {
        }
    }
}