using RPGTextuel.Core;
using RPGTextuel.RandomEvent.Class;

namespace RPGTextuel.RandomEvent.SetupEvent
{
    public class LoseCriticalChanceEvent : RandomEventClass
    {
        public override string Name => "Vision troublée";
        public override string Description => "Une migraine soudaine trouble votre perception... Vos chances de viser juste diminuent.";

        public override void Trigger(Player player)
        {
        }
    }
}