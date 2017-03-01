using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign01
{
    class Program
    {
        /**
	     * Drives the program.
	     * 
	     * @param args
	     *            command line arguments.
	     */
        static void Main(string[] args)
        {
            Program start = new Program();
            start.run();
        }

        /**
         * Runs the method for displayCalculations
         */
        private void run()
        {
            displayCalculations();
        }

        /**
         * Does all the calculations and displays them
         */
        private void displayCalculations()
        {
            int square;
            int cube;
            int baseTotal = 0;
            int squareTotal = 0;
            int cubeTotal = 0;

            // Displays header
            Console.WriteLine("{0, 7} {1, 7} {2, 7}", "number", "square", "cube");
            Console.WriteLine(new string('-', 23));

            for (int counter = 0; counter <= 20; counter += 2)
            {
                square = counter * counter;
                cube = square * counter;
                baseTotal += counter;
                squareTotal += square;
                cubeTotal += cube;

                Console.WriteLine("{0, 7:N0} {1, 7:N0} {2, 7:N0}", counter, square, cube);
            }

            // Displays the totals of all the header categories 
            Console.WriteLine(new string('-', 23));
            Console.WriteLine("{0, 7:N0} {1, 7:N0} {2, 7:N0}", baseTotal, squareTotal, cubeTotal);
            Console.ReadLine();
        }
    }
}
