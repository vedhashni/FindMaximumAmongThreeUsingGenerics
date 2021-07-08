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
            Console.WriteLine("Maximum one : " + obj.FindMaxfloat(90.2f, 25.3f, 56.5f));
        }
    }
}
