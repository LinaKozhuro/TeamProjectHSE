using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    public class Exponenta: Function
    {
        public Exponenta(double e = Math.E)
        {
            this.e = e;
        }
        public override Function Derivative()
        {
            return new Constant(Math.Log(e, Math.E)) * this;
        }

        public override string ToString()
        {
            if (Math.Abs(e - Math.E) <= 10e-6)
                return "e^x";
            return e + "^x";
        }

        private double e;
    }
}
