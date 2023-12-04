using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        try
        {
            int numerator = 15;
            int denominator = 0;

            int result = DivideByZero(numerator, denominator);
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("Program continues...");
    }

    static int DivideByZero(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero.");
        }

        return numerator / denominator;
    }
}
