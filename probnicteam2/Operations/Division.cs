using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    public class Division : Operator2
    {
        public Division( Function c, Function d) : base(c, d)
        {

        }
        public override Function Derivative()
        {
            return (upFunc.Derivative() * downFunc + downFunc * upFunc.Derivative())/(downFunc*downFunc);
        }
    }
}
