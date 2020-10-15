
// Este es el controlador principal
namespace RomanCalc
{
    class Program
    {
        public static void LaunchMainMenu()
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintMainMenu();
                string option = System.Console.ReadLine();
                System.Console.WriteLine("La opción introducida es " + option);
            }
        }

        static void Main(string[] args)
        {
            LaunchMainMenu();
        }
    }
}
