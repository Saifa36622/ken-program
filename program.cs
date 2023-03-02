using System;

namespace wowzaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your passcode : ");
            int pass = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your agency : ");
             string agent  = Console.ReadLine();

            if (pass.ToString().Length != 6)
            {
                Console.WriteLine("Error: Passcode must have 6 digits.");
            }
            else if (agent != "FBI" && agent != "NSA" && agent != "CIA")
            {
                Console.WriteLine("Error: Invalid agency.");
            }
            else if (agent == "FBI")
            {
                if (pass.ToString()[0] >= '4' && pass.ToString()[0] <= '7' &&
                    pass.ToString()[1] % 2 != 0 && pass.ToString()[3] != 6 && pass.ToString()[3] % 2 == 0)
                {
                    Console.WriteLine("Pass is valid.");
                }
                else 
                {
                    Console.WriteLine("wow");
                }
                
            }
        }
    }
}