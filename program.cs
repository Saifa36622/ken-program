using System;

namespace wowzaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your passcode : ");
            string pass = Console.ReadLine();

            Console.WriteLine("Enter your agency : ");
            string agent = Console.ReadLine();

            if (pass.Length != 6)
            {
                Console.WriteLine("Error: Passcode must have 6 digits.");
            }
            else if (agent != "FBI" && agent != "NSA" && agent != "CIA")
            {
                Console.WriteLine("Error: Invalid agency.");
            }
            else if (agent == "FBI")
            {
                if (pass[0] >= '4' && pass[0] <= '7' &&
                    pass[1] % 2 != 0 && pass[3] != '6' && pass[3] % 2 == 0)
                {
                    Console.WriteLine("Pass is valid.");
                }
                    else
                    {
                        Console.WriteLine("Error: Passcode is not valid for this agency.");
                    }
                else if (agent == "CIA")
                {
                    if (pass[5] % 3 == 0 && pass [4] != '1' && pass [4] != '3' && pass [4] != '5' && pass[2] >= 6 && pass[2] != '8')
                    {
                        Console.WriteLine("Pass is valid.");
                    }
                    else
                    {
                        Console.WriteLine("Error: Passcode is not valid for this agency.");
                    }
                }

            }

            Console.ReadLine();
        }
    }
}
