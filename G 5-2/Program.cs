using System;

namespace G_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // set our numbers up so they'll work if they're decimals
            // lesson learned from week 3 ;)
            double numone;
            double numtwo;
            double total;
            string math;

            // ask user for two numbers and assign input to variable
            Console.Write("Please enter a number:   ");
            numone = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a second number:   ");
            numtwo = Convert.ToDouble(Console.ReadLine());

            // ask the user to select a mat operation and put option into variable for furture use
            Console.WriteLine("Select a math operation: +, *, -, /.");
            math = Console.ReadLine();


            // set else is statement to loop through all possible math operations
            if (math == "*")
            {
                //set total to equal the operatin based from the numbers given
                total = multiply(numone, numtwo);
                Console.WriteLine(numone + "*" + numtwo + "=" + total);
            }
                       
            else if (math == "+")
            {
                total = add(numone, numtwo);
                Console.WriteLine(numone + "+" + numtwo + "=" + total);
            }
            
            else if (math == "-")
            {
                total = subtract(numone, numtwo);
                Console.WriteLine(numone + "-" + numtwo + "=" + total);
              }
            
            else if (math == "/")
            {
                total = divide(numone, numtwo);
                Console.WriteLine(numone + "/" + numtwo + "=" + total);
                         }

            Console.ReadLine();
        }
        // here are the methods we'll be calling on
        // the operatinos are explained here so the console knows what to do and what to put out
            private static double multiply( double numone, double numtwo)
            {
                return (numone * numtwo);
            }

            private static double divide(double numone, double numtwo)
            {
                return (numone / numtwo);
            }

            private static double add(double numone, double numtwo)
            {
                return (numone + numtwo);
            }

            private static double subtract(double numone, double numtwo)
            {
                return (numone - numtwo);
            }



        }
    }

