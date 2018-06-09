using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    public class Cos : Function
    {
        public override Function Derivative()
        {
            return -1 * Funcs.Sin;
        }

        public override string ToString()
        {
            return "cos x";
        }
    }
}
