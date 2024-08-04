using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Advanced_c_.Genaric
{
    internal class Helper <T> where T : IComparable <T>
    {

        public static void Swap (ref T x, ref T y)
        {
            T temp = x; x = y; y = temp;
        }

        //public static void Swap(ref int x, ref int y)
        //{
        //    int temp = x; x = y; y = temp;
        //}

        //public static void Swap(ref double x, ref double y)
        //{
        //    double temp = x; x = y; y = temp;
        //}
        //public static void Swap(ref Point x,ref Point y)
        //{
        //    Point temp = x; x = y; y = temp;
        //}

        //public static int SearchArray(T[] array, T element)
        //{
        //    if (array != null)
        //    {
        //        for (int i = 0; i < array.Length; i++) 
        //        {
        //            if (array[i]?.Equals(element) ?? false)
        //                return i;
        //        } 
                    
        //    }
        //    return -1;
        //}

        public static void BubbleSort (T [] array)
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length-1; i++)
                {
                    for (int j=0; j<array.Length-i-1 ; j++)
                    {
                        if(array[j].CompareTo(array[j+1]) ==1)
                        {
                            Swap (ref array[j],ref array[j+1]);
                        }
                    }
                }
            }
        }
    }
}
