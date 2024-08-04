using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range <T> where T : IComparable<T>
    {

        public T minimum { get; set; }
        public T maximum { get; set; }
        public Range(T minimum, T maximum)
        {
            this.minimum = minimum;
            this.maximum = maximum;
        }

        public bool IsInRange(T value )
        {
            if (value.CompareTo(minimum) >= 0 && value.CompareTo(maximum) <= 0)
                return true;
            return false;
        }

        public T Length()
        {
            dynamic mn = minimum;
            dynamic mx = maximum;
            return mx - mn;
        }
    }
}
