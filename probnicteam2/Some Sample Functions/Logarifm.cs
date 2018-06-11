using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    public class Logarifm : Function
    {
        public override Function Derivative()
        {
            return new Constant(1);
        }
    }
}
