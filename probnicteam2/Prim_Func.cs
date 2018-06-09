using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probnicteam2
{
    public static class Prim_Func
    {
        public static readonly Function Sf = new Sample_Func();
        public static readonly Function Exp = new Exponenta();
        public static readonly Function Zero = new Constant(0);
        public static readonly Function Sin = new Sin();
        public static readonly Function Cos = new Cos();
        public static readonly Function Ln = new Logarifm();

        public static readonly Function Tan = Sin / Cos;
        public static readonly Function Ctg = Cos / Sin;
        public static readonly Function Sh = (Exp - 1 / Exp) / 2;
        public static readonly Function Ch = (Exp + 1 / Exp) / 2;
        public static readonly Function Tgh = Sh / Ch;
        public static readonly Function Cth = Sh / Ch;
    }
}
