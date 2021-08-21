using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables for program
            int num1;
            int num2;
            int calc;
            int result;

            //Prompt user for first number 
            Console.WriteLine("Calculation Program!");
            Console.Write("Please enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            //prompt user for second number 
            Console.Write("Please enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            calc = Convert.ToInt32(Console.ReadLine()); 

            if (calc == 1)
            {
                result = num1 + num2;

                Console.WriteLine("The sum of " + num1.ToString() + " and " + num2.ToString()
                                   + " is " + result.ToString() + ".");
                Console.ReadLine(); 

            }// else if(calc == 2)
            //{/
//                result = ()
    //        }






        }
    }
}
