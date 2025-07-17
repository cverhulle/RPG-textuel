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

        // Cette méthode teste CanBeHealed avec une vie non pleine
        public static void TestCanBeHealedNotWithFullHealth()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();
            player.TakeDamage(20);
            Console.WriteLine("Le joueur peut-il être soigné ?");
            Console.WriteLine(player.CanBeHealed(1));
        }

        // Cette méthode teste Heal avec une vie pleine
        public static void TestHealWithFullHealth()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();
            Console.WriteLine(player.Heal(1));
        }

        // Cette méthode teste Heal avec une vie pleine non pleine
        public static void TestHealNotWithFullHealth()
        {
            Player player = TestPlayerFactory.TestPlayerCreation();
            player.TakeDamage(20);
            Console.WriteLine(player.Heal(1));
        }
    }
}