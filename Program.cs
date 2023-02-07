using System.Diagnostics.Metrics;

namespace deliverable4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declare the Fibonacci Array to contain 25 items/numbers
            int[] fibonacciArray = new int[25];

            /* 
             * Initialize Array for index 0 and 1 since the formula does not work with those two numbers
             * It comes out negative if those numbers are included
             * Line 33 will say an error that "The Index was outside the bounds of the array" 
            */
            fibonacciArray[0] = 0;
            fibonacciArray[1] = 1;

            //Declare a index
            int i;

            //Write a for loop
            for (i = 0; i < 25; i++)
            {
                /*
                 * Since The Fibonacci calculation does not work with numbers 0 and 1
                 * Write a loop for the Array to display what is stored at 0 and 1
                 * Additionally instead of two if statements
                 * Lets make it one by only including the calculations for numbers greater than 1
                 * So the command prompt will only have to write what is stored at those indexes
                 * But in cases where index is greater than 1 calculate the Fibonnaci number at that index and write it
                 */
                if (i > 1)
                {
                    fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
                }

                Console.WriteLine("Fibonacci (" + i + ") = " + fibonacciArray[i]);




            }
        }
        
    }
}