using System;

namespace Metoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double a, b;
            string name, userInput;
            byte age;

            #region Exercise 1

            do
            {
                Console.Clear();
                Console.WriteLine("Enter an integer for x: ");
                userInput = Console.ReadLine();
            }
            while (!int.TryParse(userInput, out x));

            do
            {
                Console.Clear();
                Console.WriteLine("Enter another integer for y: ");
                userInput = Console.ReadLine();
            }
            while (!int.TryParse(userInput, out y));

            Console.Clear();

            Console.WriteLine(DoMath(x, y));

            Console.ReadKey();

            #endregion

            #region Exercise 2

            Console.Clear();

            do
            {
                Console.Clear();
                Console.WriteLine("Enter a number for a^2: ");
                userInput = Console.ReadLine();
            }
            while (!double.TryParse(userInput, out a));

            do
            {
                Console.Clear();
                Console.WriteLine("Enter another number for b^2: ");
                userInput = Console.ReadLine();
            }
            while (!double.TryParse(userInput, out b));

            Console.WriteLine(Pythagoras(a, b));

            Console.ReadKey();

            #endregion

            #region Exercise 3

            Console.Clear();

            Console.WriteLine("Indtast dit navn: ");
            name = Console.ReadLine();

            do
            {
                Console.WriteLine("Indtast din alder: ");
                userInput = Console.ReadLine();
            }
            while (!byte.TryParse(userInput, out age));

            Console.WriteLine(Age(name, age));

            Console.ReadKey();

            #endregion
        }

        /// <summary>
        /// Exercise 1
        /// </summary>
        /// <param name="x">A number</param>
        /// <param name="y">Another number</param>
        /// <returns></returns>
        private static string DoMath(int x, int y)
        {
            string output;

            output = $"x was {x}, y was {y}";
            output += $"x + y = {x + y}\n";
            output += $"x / y (rounded down) = {x/y}\n";
            output += $"x / y = {((double)x / (double)y):N2}\n";
            output += $"x goes into y {y/x} times.\n";
            output += $"x^y = {Math.Pow(x,y)}\n";

            return output;
        }

        /// <summary>
        /// Exercise 2
        /// </summary>
        /// <param name="aPow2"></param>
        /// <param name="bPow2"></param>

        private static string Pythagoras(double aPow2, double bPow2)
        {
            double a, b, c;
            string output;

            a = Math.Sqrt(aPow2);
            b = Math.Sqrt(bPow2);

            c = a + b;

            output = $"a² + b² = c²\nc = {c}\n\n";

            if (a > b)
            {
                output += $"a was bigger. ({a} > {b})\n";
            }
            else
            {
                output += $"b was bigger. ({b} > {a})\n";
            }

            return output;
        }

        /// <summary>
        /// Exercise 3
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        private static string Age(string name, byte age)
        {
            if (age < 3) // age < 3
            {
                return $"{name}, du må gå med ble.";
            }
            else if (age > 3 && age <= 15) // Age between 3 and 15
            {
                return $"{name}, du må ingenting.";
            }
            else if (age > 15 && age < 18) // Age between 15 and 18 (15 and 18 excluded)
            {
                return $"{name}, du må drikke.";
            }
            else // Age 18 and above
            {
                return $"{name}, du må stemme og køre bil.";
            }
        }
    }
}