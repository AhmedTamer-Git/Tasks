using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10TaskC_
{
    internal class SortingAlgorithm<T> where T : ICloneable
    {
        public void Sort(T[] array, Comparison<T> comparison)
        {
            Array.Sort(array, comparison);
        }


        public static void Swap<TItem>(ref TItem a, ref TItem b)
        {
            TItem temp = a;
            a = b;
            b = temp;
        }

        public T[] CloneArray(T[] array)
        {
            T[] clone = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
                clone[i] = (T)array[i].Clone();
            return clone;
        }

    }
}
