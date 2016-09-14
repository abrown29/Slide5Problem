using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide5Problem
{
    class Program
    {
        public static void Main()
        {
            int[] example = { 20, 10, 5, 2 };
            Console.WriteLine("The sum of of the example array is {0}", Sum(example));
        }

        static int Sum(int [] example)
        {
            int placeHolder = 0;
            foreach(int number in example)
            {
                placeHolder += number;
            }
            return placeHolder;
        }
    }
}
