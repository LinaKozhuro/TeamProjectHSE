using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    public abstract class Function
    {
        public abstract Function Derivative();

        public static Function operator +(Function a, Function b)
        {
            return new Addition(a, b);
        }

        public static Function operator +(double k, Function b)
        {
            return new Constant(k) + b;
        }

        public static Function operator *(Function a, Function b)
        {
            return new Multiplication(a, b);
        }
        public static Function operator /(Function c, Function d)
        {
            return new Division(d, c);
        }
        public static Function operator -(Function a, Function b)
        {
            return new Minus(a, b);
        }
        public static Function operator ^(Function q)
        {
            return new Involution(q);
        }
        
    }
}
