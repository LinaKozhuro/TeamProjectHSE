using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    public class Constant : Function // realisation of Constant
    {
        public Constant(double val)
        {
            value = val;
        }
        public override Function Derivative()
        {
            return new Constant(0);
        }
        private readonly double value;
    }
}
