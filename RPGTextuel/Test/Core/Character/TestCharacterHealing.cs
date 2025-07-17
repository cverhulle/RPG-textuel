using RPGTextuel.Core;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.CoreCharacter
{
    // Cette classe teste les méthode du fichier Healing de Character.
    public static class TestCharacterHealing
    {
        // Cette méthode teste CanBeHealed avec une vie pleine
        public static void TestCanBeHealedWithFullHealth()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();
            Console.WriteLine("Le joueur peut-il être soigné ?");
            Console.WriteLine(player.CanBeHealed(1));
        }
    }
}