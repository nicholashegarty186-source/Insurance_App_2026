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

        // show title screen
        static void ShowTitleScreen()
        {
            Console.WriteLine(" /$$$$$$                                                                                       /$$$$$$                     \r\n|_  $$_/                                                                                      /$$__  $$                    \r\n  | $$   /$$$$$$$   /$$$$$$$ /$$   /$$  /$$$$$$  /$$$$$$  /$$$$$$$   /$$$$$$$  /$$$$$$       | $$  \\ $$  /$$$$$$   /$$$$$$ \r\n  | $$  | $$__  $$ /$$_____/| $$  | $$ /$$__  $$|____  $$| $$__  $$ /$$_____/ /$$__  $$      | $$$$$$$$ /$$__  $$ /$$__  $$\r\n  | $$  | $$  \\ $$|  $$$$$$ | $$  | $$| $$  \\__/ /$$$$$$$| $$  \\ $$| $$      | $$$$$$$$      | $$__  $$| $$  \\ $$| $$  \\ $$\r\n  | $$  | $$  | $$ \\____  $$| $$  | $$| $$      /$$__  $$| $$  | $$| $$      | $$_____/      | $$  | $$| $$  | $$| $$  | $$\r\n /$$$$$$| $$  | $$ /$$$$$$$/|  $$$$$$/| $$     |  $$$$$$$| $$  | $$|  $$$$$$$|  $$$$$$$      | $$  | $$| $$$$$$$/| $$$$$$$/\r\n|______/|__/  |__/|_______/  \\______/ |__/      \\_______/|__/  |__/ \\_______/ \\_______/      |__/  |__/| $$____/ | $$____/ \r\n                                                                                                       | $$      | $$      \r\n                                                                                                       | $$      | $$      \r\n                                                                                                       |__/      |__/      ");

            Console.WriteLine("This program calculates the insurance");
            Console.WriteLine("cost for school devices and shows how");
            Console.WriteLine("their value depreciates over 6 months.");

            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
        }

        //process a device
        static string ProcessDevice()
        {
            Console.WriteLine("----- Enter Device Information -----\n");

            string name = CheckName("Enter device name:");
            int number = CheckInt("Enter number of devices:", 1, 100);
            decimal cost = CheckDecimal("Enter cost of each device:");
            int category = CheckInt(
                "Enter category (1=Laptop, 2=Desktop, 3=Other):",
                1,
                3
            );

            decimal insuranceCost = CalculateInsurance(number, cost);

            reports += GenerateReport(name, number, cost, category);

            deviceCounter++;
            totalInsurance += insuranceCost;

            // Update most expensive device
            if (insuranceCost > topCost)
            {
                topCost = insuranceCost;
                topDevice = name;
            }

            return "\nDevice processed successfully.";
        }

        //Insurance Calculation
        static decimal CalculateInsurance(int number, decimal cost)
        {
            if (number > 5)
            {
                decimal firstFive = 5 * cost;
                decimal remaining = (number - 5) * cost * DISCOUNT;

                return firstFive + remaining;
            }

            return number * cost;
        }

        //Depreciation Calculation
        static List<decimal> CalculateDepreciation(decimal cost)
        {
            List<decimal> values = new List<decimal>();

            decimal value = cost;

            for (int month = 1; month <= 6; month++)
            {
                value *= DEPRECIATION;
                values.Add(Math.Round(value, 2));
            }

            return values;
        }

        // Generate Device Report
        static string GenerateReport(string name, int number, decimal cost, int category)
        {
            string report = "\n------ Device Report ------\n";

            decimal insurance = CalculateInsurance(number, cost);

            report += $"Device Name: {name}\n";
            report += $"Total Insurance Cost: ${insurance:F2}\n";

            report += "\nMonth   Value\n";

            List<decimal> values = CalculateDepreciation(cost);

            for (int i = 0; i < values.Count; i++)
            {
                report += $"{i + 1}       ${values[i]}\n";
            }

            report += $"CATEGORY: {deviceCategories[category - 1]}\n";
            report += "---------------------------\n";

            return report;
        }

        //Input Validation
        static string CheckName(string question)
        {
            while (true)
            {
                Console.WriteLine(question);
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input;

                Console.WriteLine("Invalid name. Please try again.");
            }
        }

        static int CheckInt(string question, int min, int max)
        {
            while (true)
            {
                Console.WriteLine(question);

                try
                {
                    int value = Convert.ToInt32(Console.ReadLine());

                    if (value >= min && value <= max)
                        return value;

                    Console.WriteLine($"Enter a number between {min} and {max}");
                }
                catch
                {
                    Console.WriteLine("Invalid number.");
                }
            }
        }

    }
}
