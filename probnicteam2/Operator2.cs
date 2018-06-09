using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    public abstract class Operator2 : Function // second class for combinators
    {
        protected Operator2(Function c, Function d)
        {
            upFunc = c;
            downFunc = d;

        }
        protected readonly Function upFunc;
        protected readonly Function downFunc;
    }
}
