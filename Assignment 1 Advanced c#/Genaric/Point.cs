using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Advanced_c_.Genaric
{
    internal class Point : IComparable<Point>
    {

        public int x {  get; set; }
        public int y { get; set; }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{x} , {y}";
        }

        public int CompareTo(Point? other)
        {
            if (other == null) return 1 ;
            if (other.x == this.x )
                return this.y.CompareTo(other.y);
            else
                return this.x.CompareTo(other.x);
        }

        //public int CompareTo(object? obj)
        //{
        //   Point? p = obj  as Point;
        //    if (this.x == p?.x)
        //        return this.y.CompareTo(p?.y);
        //    else 
        //        return this.x.CompareTo(p?.x);
        //}
    }
}
