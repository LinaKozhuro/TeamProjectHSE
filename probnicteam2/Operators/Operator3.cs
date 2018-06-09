using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    public abstract class Operator3 : Function // third class for combinators
    {
        protected Operator3(Function q)
        {
            involVal = q;

        }
        protected readonly Function involVal;
    }
}
