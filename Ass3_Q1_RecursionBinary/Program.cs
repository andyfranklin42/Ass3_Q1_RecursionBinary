using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3_Q1_RecursionBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteredVal = 0;
            while (true)
            {

                //unit testing
                //unitTest();
                
                //read file name
                Console.WriteLine("");
                Console.WriteLine("Please enter int value (-1 to break) :");
                enteredVal = Convert.ToInt32(Console.ReadLine());

                if (enteredVal == -1) { break; }
                printBinary(enteredVal);
            }
            //always included code to make sure you can see the output before the console closes
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void printBinary(int enteredVal)
        {
            if (enteredVal != 0)
            {
                int newVal = enteredVal / 2;
                printBinary(newVal);
                Console.Write(enteredVal % 2);
            }
            
        }

        private static void unitTest()
        {
            for(int i = 0; i<50; i++)
            {
                printBinary(i);
                Console.Write(Environment.NewLine);
            }
        }
    }
}
