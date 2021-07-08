using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find maximum problem");
            FindMaxAmongThree obj = new FindMaxAmongThree();
            obj.FindMax(70, 35, 56);
        }
    }
}
