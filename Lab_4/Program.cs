using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program 
    {
        static void Main(string[] args)
        {
            int userNum, i; //delacring variable

            do
            {
                Console.WriteLine("Enter the stop number");//asking for user input and storing it
                userNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Number Squared  Cubed");//labeling and break lines for each columns
                Console.WriteLine("====== ======= ======="); 

                for (i = 1; i <= userNum; i++) //loop conditions
                {

                    Console.WriteLine("{0}{1}{2}{3}{4}", i, " \t", Math.Pow(i, 2), "\t", Math.Pow(i, 3));// Math.Pow squres and cubes i  

                }

                Console.WriteLine("Would you like to contiue y/n?");
            }

                   
            while (Console.ReadLine() == "y"); // loop to restart and end start program
            {
                Console.WriteLine("Goodbye");
            }


        }
    }
}
