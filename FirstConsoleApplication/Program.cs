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
            Boolean more = true;

            while (more)
            {

                try
                {

                    //Prompt user for first number 
                    Console.WriteLine("Calculation Program!");
                    Console.Write("Please enter your first number: ");
                    num1 = Convert.ToInt32(Console.ReadLine().Replace(" ", ""));

                    //prompt user for second number 
                    Console.Write("Please enter your second number: ");
                    num2 = Convert.ToInt32(Console.ReadLine().Replace(" ", "")); 

                    //prompt choices of operation to user 

                    Console.WriteLine("Enter 1 for Addition");
                    Console.WriteLine("Enter 2 for Subtraction");
                    Console.WriteLine("Enter 3 for Multiplication");
                    calc = Convert.ToInt32(Console.ReadLine());

                    //if 1 is selection result will be addition 

                    if (calc == 1)
                    {
                        result = num1 + num2;

                        Console.WriteLine("The sum of " + num1.ToString() + " and " + num2.ToString()
                                           + " is " + result.ToString() + ".");



                    }  //if 2 is selected result will be subtraction
                    else if (calc == 2)
                    {

                        result = num1 - num2;

                        Console.WriteLine(num1.ToString() + " minus " + num2.ToString()
                                           + " is equal to " + result.ToString() + ".");



                    }  //if 3 is selected result will be multiplication. 
                    else if (calc == 3)
                    {
                        result = num1 * num2;

                        Console.WriteLine(num1.ToString() + " multiplied by " + num2.ToString()
                                           + " is " + result.ToString() + ".");


                    } // if 1, 2, or 3 is not selected 
                    else if (calc > 3 || calc < 1)
                    {
                        Console.WriteLine("Please choose either 1, 2, or 3 to calculate.");

                    }
                    //prompt for more operations else exit

                    Console.WriteLine("Would you like to do another calculation? Yes/No?.");
                    string cont = Console.ReadLine().ToUpper();
                    string answer = cont.Substring(0, 1);

                    if (answer == "N")
                    {
                        more = false;

                    }

                    Console.WriteLine(""); 

                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Numeric Values Only");
                    Console.WriteLine(""); 
                }



            }
        }
    }

}
