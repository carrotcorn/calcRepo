using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("**************CALUCLATOR****************");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("******************MENU******************");

            Console.WriteLine("GIMME A NUMBER BOSS, THE PRESS ENTER");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("GIMME ANOTHER NUMBER BOSS, THEN PRESS ENTA");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("CHOOSE HOW YOU WANNA CALCULATE");

            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t* - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.WriteLine("\t% - Divide");
            Console.Write("Your option? ");

            
            String userInput = Console.ReadLine();

            if(userInput == "+")
            {
                Console.WriteLine($"your result is: " + (num1 + num2));
            }
            else if (userInput == "-")
            {
                Console.WriteLine($"your result is: " + (num1 - num2));
            }
            else if (userInput == "*")
            {
                Console.WriteLine($"your result is: " + (num1 * num2));
            }
            else if (userInput == "/")
            {
                Console.WriteLine($"your result is: " + (num1 / num2));
            }
            else if (userInput == "%")
            {
                Console.WriteLine($"your result is: " + (num1 % num2));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
