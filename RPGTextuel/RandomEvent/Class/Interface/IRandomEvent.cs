using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;

namespace RPGTextuel.RandomEvent.Class.Interface
{
    // Cette interface permet de typer les événements.
    public interface IRandomEvent
    {
        // On liste le nom et la description de l'événement
        string Name { get; }
        string Description { get; }

        // Méthode pour déclencher l'évenement.
        // Si l'événement ne concerne pas une entité, on lui passe null
        void Trigger(Player? player, Enemy? enemy);
    }
}