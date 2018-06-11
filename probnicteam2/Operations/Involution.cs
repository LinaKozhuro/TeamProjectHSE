using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    public class Involution : Operator3// возведение в степень
    {
        public Involution(Function q) : base(q)
        {
            double q = Math.Pow
                this.q = q;
        }


       /* public Involution(double q = Math.Pow)
        {
            this.q = q;
        }*/
        public override Function Derivative()
        {
            return new Constant(Math.Log(p, Math.Pow)) * this;
        }

        

        private double e;

    }
}
