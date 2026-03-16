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

        public static int deviceCounter = 0;
        public static string reports = "";

        public static List<string> deviceCategories =
        new List<string> { "Laptop", "Desktop", "Other" };

        static void Main(string[] args)
       static void Main(string[] args)
        {
            ShowTitleScreen(Console.WriteLine(" /$$$$$$                                                                                       /$$$$$$                     \r\n|_  $$_/                                                                                      /$$__  $$                    \r\n  | $$   /$$$$$$$   /$$$$$$$ /$$   /$$  /$$$$$$  /$$$$$$  /$$$$$$$   /$$$$$$$  /$$$$$$       | $$  \\ $$  /$$$$$$   /$$$$$$ \r\n  | $$  | $$__  $$ /$$_____/| $$  | $$ /$$__  $$|____  $$| $$__  $$ /$$_____/ /$$__  $$      | $$$$$$$$ /$$__  $$ /$$__  $$\r\n  | $$  | $$  \\ $$|  $$$$$$ | $$  | $$| $$  \\__/ /$$$$$$$| $$  \\ $$| $$      | $$$$$$$$      | $$__  $$| $$  \\ $$| $$  \\ $$\r\n  | $$  | $$  | $$ \\____  $$| $$  | $$| $$      /$$__  $$| $$  | $$| $$      | $$_____/      | $$  | $$| $$  | $$| $$  | $$\r\n /$$$$$$| $$  | $$ /$$$$$$$/|  $$$$$$/| $$     |  $$$$$$$| $$  | $$|  $$$$$$$|  $$$$$$$      | $$  | $$| $$$$$$$/| $$$$$$$/\r\n|______/|__/  |__/|_______/  \\______/ |__/      \\_______/|__/  |__/ \\_______/ \\_______/      |__/  |__/| $$____/ | $$____/ \r\n                                                                                                       | $$      | $$      \r\n                                                                                                       | $$      | $$      \r\n                                                                                                       |__/      |__/      ");

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

      