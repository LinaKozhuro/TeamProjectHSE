﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    public class Minus : Operator
    {
        public Minus(Function a, Function b) : base(a, b)
        {

        }

        public override Function Derivative()
        {
            return leftFunc.Derivative() - rightFunc.Derivative();
        }
    }
}
