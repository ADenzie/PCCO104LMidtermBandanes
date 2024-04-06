using System;

class Program
{
    static void Main(string[] args)
    {
        int baseFanPower = 10;
        int fanSpeed;
        string oscillateOption;

        while (true)
        {
            Console.Write("Enter fan speed (1, 2, or 3): ");
            fanSpeed = Convert.ToInt32(Console.ReadLine());

            if (fanSpeed >= 1 && fanSpeed <= 3)
                break;

            Console.WriteLine("INVALID value. Please enter again.");
        }
      
        Console.WriteLine();
      
        while (true)
        {
            Console.Write("Enter oscillate option (Y or N): ");
            oscillateOption = Console.ReadLine().ToUpper();

            if (oscillateOption == "Y" || oscillateOption == "N")
                break;

            Console.WriteLine("INVALID value. Please enter again.");
        }

        int fanPowerOutput = baseFanPower * fanSpeed;

        if (oscillateOption == "Y")
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new String('~', i * fanSpeed));
            }
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(new String('~', i * fanSpeed));
            }
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new String('~', fanPowerOutput));
            }
        }
    }
}
