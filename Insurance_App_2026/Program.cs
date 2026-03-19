namespace Wages_App
{
    public class Program
    {
        // Global Constants
        public const decimal DISCOUNT = 0.9m;
        public const decimal DEPRECIATION = 0.95m;

        // Global Variables
        public static decimal totalInsurance = 0.0m;
        public static string topDevice = "";
        public static decimal topCost = 0.0m;
        public static string CheckName = "";

        public static int deviceCounter = 0;
        public static string reports = "";

        public static List<string> deviceCategories =
            new List<string> { "Laptop", "Desktop", "Other" };

        static void Main(string[] args)
        {
            ShowTitleScreen();

            char continueInput = 'y';

            while (continueInput == 'y')
            {
                Console.Clear();

                Console.WriteLine(ProcessDevice());

                continueInput = CheckContinueInput(
                    "\nDo you want to enter another device? (y/n)"
                );
            }

            Console.Clear();

            Console.WriteLine(reports);

            ShowSummary();
        }

        //show title screen
        static void ShowTitleScreen()
        {



        }

    
    
    }
}
