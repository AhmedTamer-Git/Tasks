using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10TaskC_
{
    internal class SortingTwo<T>
    {
        public void Sort(T[] array, Comparison<T> comparer)
        {
            Array.Sort(array, comparer);
        }
    }
}
