using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblem
{
    public class SortingClass<T> where T : IComparable
    {
        public T[] arrayList;
        public SortingClass(T[] arrayList)
        {
            this.arrayList = arrayList;
        }
        public T[] Sorting(T[] arrayList)
        {
            Array.Sort(arrayList);
            return arrayList;
        }
        public T MaximumValueFunction(T[] arrayList)
        {
            var sortarrayval = Sorting(arrayList);
            return sortarrayval[arrayList.Length - 1];
        }
        public T MaxMethod()
        {
            T maxValue = this.MaximumValueFunction(arrayList);
            return maxValue;
        }
        public void PrintGreatestValue()
        {
            var max = MaxMethod();
            Console.WriteLine("Maximum value is: {0}", max);
        }

    }
}
