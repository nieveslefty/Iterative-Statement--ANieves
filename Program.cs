using System;

namespace Iterative_Statement__ANieves
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; //input integer

            //Ask the user to enter an integer value between 1 and 100
            Console.WriteLine("Please enter an integer value between 1 and 100");
            string input = Console.ReadLine();

            //parse to integer
            if (int.TryParse(input, out number))
            {
                if (number >= 1 && number < 100)
                {

                    for (int i = 0; i < number; i++)
                    {
                        Console.WriteLine("You have entered {0}. This is the current integer value in the loop: {1}",
                     number, i + 1);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number. The number must be 1 and 100");
                }
            }
            else
            {
                Console.WriteLine("Invalid number. The number must be an integer number");
            }

            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);

        } //end main
    } //end of class
}//end namespace
