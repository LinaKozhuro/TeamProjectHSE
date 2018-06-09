using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    public abstract class Operator : Function //class for combinators
    {
        protected Operator(Function a, Function b)
        {
            leftFunc = a;
            rightFunc = b;
           
        }
        protected readonly Function leftFunc;
        protected readonly Function rightFunc;
    }
}
