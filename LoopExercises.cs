using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Assignment
{
    class LoopExercises
    {
        public void DrawBox(int s) #method for drawing a box with an integer as a parameter
        {
             int y = 0; #sets the integer to 0
            while (y < s) #while loop
            {
                y++; #increments the y variable 
             int x = 0; #sets the x variable to 0

                
                while (x < s) #while loop x<s
                {
                    Console.Write("*"); #writes the character out to the console
                    x++; #increments the x variable 

                }
                Console.WriteLine();
            }

        }

        public void GetFactorial(int l) #method for the factorial with an integer as a parameter
        {
            int value = 1; #sets the value variable to 1
            int i = 1; #sets the i variable to 1
            while(i <= l) #while loop (while i is < l)
            {
                value = value * i; #multiplies i and the value to create a new product for value
                i++;
            Console.WriteLine($"{value}"); #writes out the value to the console

            }


        }

      /*  public void ShowE(int precision)
        {
            //E is 1+(1/n!) + (1/n!) + (1/ (n+!)!)+.... 
            double runningTotal = 1;

            int n = 0;
            while(n < precision)
            {
                n++;

                runningTotal = runningTotal + (1 / (GetFactorial(n)));
            }
            Console.WriteLine($"E with a precision of {precision} is {runningTotal}");
        } */
    }
}
