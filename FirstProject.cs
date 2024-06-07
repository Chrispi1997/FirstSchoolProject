// See https://aka.ms/new-console-template for more information
using System;

namespace Project
{
    class Math
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string firstnumber = Console.ReadLine();

            Console.WriteLine("Please enter another number:");
            string secondnumber = Console.ReadLine();

            try
            {
                int numero1 = Convert.ToInt32(firstnumber);
                int numero2 = Convert.ToInt32(secondnumber);

                int result = numero1 / numero2;
                Console.WriteLine("The answer is:" +result);
            }
            catch (FormatException)
            {
                Console.WriteLine("You did something wrong");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Why are you trying to divide by zero?");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Calm down there, lets keep it simple");
            }
        }
    }
}
