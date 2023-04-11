using System;

namespace Methods_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number"); // Asks for the user to input a whole number
            int x = Convert.ToInt32(Console.ReadLine()); // Converts and assigns the first number they input to int x
            Console.WriteLine("Enter a whole number"); // Asks for the user to input a whole number
            int y = Convert.ToInt32(Console.ReadLine()); // Convers and assigns the second number they input to int y

            Console.WriteLine(Multiply(x,y)); // Calls method and prints answer to the console

            Console.WriteLine("What is your name?"); // Asks user their name
            string name = Console.ReadLine(); // Assings their input to string 

            WelcomeUser(name); // Calls the method

            Goodbye(); // Calls the method
        }

        /// <summary>
        /// Multiplies both of the inputted numbers and returns an answer to the console
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        
        /// <summary>
        /// Prints out confirming their name to the console
        /// </summary>
        /// <param name="username"></param>
        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Are you, {username}?");
        }

        /// <summary>
        /// Prints out the goodbye message to the console
        /// </summary>
        static void Goodbye()
        {
            Console.WriteLine("Have a nice day.");
        }
    }
}
