using RPGTextuel.Core;
using RPGTextuel.Extensions.Characters;
using RPGTextuel.Game.GameUtilsNamespace;
using RPGTextuel.Test.Core;

namespace RPGTextuel.Test.CoreCharacter
{
    // Cette classe teste les méthode du fichier Healing de Character.
    public static class TestCharacterHealing
    {
        // Cette méthode teste CanBeHealed avec une vie pleine
        public static void TestCanBeHealedWithFullHealth()
        {
            Console.WriteLine("=== Test : CanBeHealed (vie pleine) ===");

            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            player.PrintHealthBar();

            bool result = player.CanBeHealed(1);
            Console.WriteLine($"Résultat de CanBeHealed(1) : {result} (attendu : False)");

            GameUtils.WaitForUser();
        }

        // Cette méthode teste CanBeHealed avec une vie non pleine
        public static void TestCanBeHealedNotWithFullHealth()
        {
            Console.WriteLine("=== Test : CanBeHealed (vie non pleine) ===");
            Player player = PlayerTestFactory.CreateWoundedPlayer(20);
            player.PrintHealthBar();


            bool result = player.CanBeHealed(1);
            Console.WriteLine($"Résultat de CanBeHealed(1) : {result} (attendu : True)");

            GameUtils.WaitForUser();
        }

        // Cette méthode teste Heal avec une vie pleine
        public static void TestHealWithFullHealth()
        {
            Console.WriteLine("=== Test : Heal (avec vie pleine) ===");
            Player player = PlayerTestFactory.CreateBasicTestPlayer();
            player.PrintHealthBar();

            player.Heal(1);

            player.PrintHealthBar(); // Pas de changement attendu.

            GameUtils.WaitForUser();
        }

        // Cette méthode teste Heal avec une vie pleine non pleine
        public static void TestHealNotWithFullHealth()
        {
            Console.WriteLine("=== Test : Heal (avec vie manquante) ===");

            Player player = PlayerTestFactory.CreateWoundedPlayer(20);
            player.PrintHealthBar();

            Console.WriteLine("Soins de 10 PV...");
            player.Heal(10);

            player.PrintHealthBar(); // Augmentation attendue

            GameUtils.WaitForUser();
        }
    }
}