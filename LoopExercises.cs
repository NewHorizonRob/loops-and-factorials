using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Assignment
{
    class LoopExercises
    {
        public void DrawBox(int s)
        {
             int y = 0;
            while (y < s)
            {
                y++;
             int x = 0;

                
                while (x < s)
                {
                    Console.Write("*");
                    x++;

                }
                Console.WriteLine();
            }

        }

        public void GetFactorial(int l)
        {
            int value = 1;
            int i = 1;
            while(i <= l)
            {
                value = value * i;
                i++;
            Console.WriteLine($"{value}");

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
