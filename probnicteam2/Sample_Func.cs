using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    class Sample_Func: Function // line func realisation  f(x) = x
    {
        public override Function Derivative()
        {
            return new Constant(1);
        }
    }
}

