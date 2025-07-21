using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment05
{
    internal class _3DPoint:IComparable,ICloneable
    {
        public _3DPoint(_3DPoint Origin) //Copy constructor
        {
            this.X= Origin?.X??0;
            this.Y= Origin?.Y??0;
            this.Z= Origin?.Z ?? 0;
        }
        public  double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public _3DPoint(double x,double y, double z) 
        {
            X= x;
            Y= y;
            Z= z;
        }
        public _3DPoint(double x,double y):this(x,y,0)
        {
            
        }
        public _3DPoint(double x):this(x,0,0)
        {
            
        }
        public _3DPoint():this(0,0,0)
        {
            
        }
        public override string ToString()
        {
            return $"X={X}, Y={Y} , Z={Z}";
        }
        // 1. Override Equals
        #region Overloading '=='(ChatGptCode)
        public override bool Equals(object obj)
        {
            if (obj is _3DPoint other)
                return X == other.X && Y == other.Y && Z == other.Z;

            return false;
        }

        // 2. Override GetHashCode (used in collections like Dictionary, HashSet)
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

       

        // 3. Overload == operator
        public static bool operator ==(_3DPoint a, _3DPoint b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;

            return a.Equals(b);
        }

        // 4. Overload != operator
        public static bool operator !=(_3DPoint a, _3DPoint b)
        {
            return !(a == b);
        } 
        #endregion 
       

        public int CompareTo(object? obj)
        {
           _3DPoint other=(_3DPoint)obj;

            if (other is null) return 1;
            int Result = this.X.CompareTo(other.X);
            if (Result == 0)
                Result = this.Y.CompareTo(other.Y);
            return Result;
        }

        public object Clone()
        {
            return new _3DPoint()
            {
                X = this.X,
                Y = this.Y,
                Z=this.Z

            };


        }
    }

}
