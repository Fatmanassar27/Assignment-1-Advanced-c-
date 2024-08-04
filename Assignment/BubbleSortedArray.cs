using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BubbleSortedArray
    {
        public static void BubbleSortv<T> (T[]array) where T : IComparable<T> 
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    bool flag = false;
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].CompareTo(array[j+1]) == 1)
                        {
                            T temp = array[j];
                            array[j] = array[j+1];
                            array[j+1] = temp;
                            flag = true;
                        }
                    }
                    if (!flag)
                        break;
                }
            }
        }
    }
}
