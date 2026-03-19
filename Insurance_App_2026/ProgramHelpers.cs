namespace Wages_App
{
    internal static class ProgramHelpers
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" /$$$$$$                                                                                       /$$$$$$                     \r\n|_  $$_/                                                                                      /$$__  $$                    \r\n  | $$   /$$$$$$$   /$$$$$$$ /$$   /$$  /$$$$$$  /$$$$$$  /$$$$$$$   /$$$$$$$  /$$$$$$       | $$  \\ $$  /$$$$$$   /$$$$$$ \r\n  | $$  | $$__  $$ /$$_____/| $$  | $$ /$$__  $$|____  $$| $$__  $$ /$$_____/ /$$__  $$      | $$$$$$$$ /$$__  $$ /$$__  $$\r\n  | $$  | $$  \\ $$|  $$$$$$ | $$  | $$| $$  \\__/ /$$$$$$$| $$  \\ $$| $$      | $$$$$$$$      | $$__  $$| $$  \\ $$| $$  \\ $$\r\n  | $$  | $$  | $$ \\____  $$| $$  | $$| $$      /$$__  $$| $$  | $$| $$      | $$_____/      | $$  | $$| $$  | $$| $$  | $$\r\n /$$$$$$| $$  | $$ /$$$$$$$/|  $$$$$$/| $$     |  $$$$$$$| $$  | $$|  $$$$$$$|  $$$$$$$      | $$  | $$| $$$$$$$/| $$$$$$$/\r\n|______/|__/  |__/|_______/  \\______/ |__/      \\_______/|__/  |__/ \\_______/ \\_______/      |__/  |__/| $$____/ | $$____/ \r\n                                                                                                       | $$      | $$      \r\n                                                                                                       | $$      | $$      \r\n                                                                                                       |__/      |__/      ");
            Console.WriteLine("How many Devices do you want to enter+");
        }


        static void Main(string[] args)
        {
            {

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

                Console.WriteLine(Program.reports);
                Program.
                            ShowSummary();



            }
    }
}