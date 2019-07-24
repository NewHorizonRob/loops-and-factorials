using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopExercises h = new LoopExercises(); #initializes a new instance from the LoopExercises class
          h.DrawBox(7); #each of these are method calls from the LoopExercises class used in this class 
          h.GetFactorial(4);
          //  h.ShowE(2);
            Console.WriteLine("PAK");
            Console.ReadKey();
        }
    }
}
