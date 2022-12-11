using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SkellamDistribution
{
    class FortranLib
    {
        [DllImport("TriangleDistrDLL.dll", EntryPoint = "__triangulation_MOD_reversefunc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int reverseFunc(ref double a, ref double b);

        [DllImport("TriangleDistrDLL.dll", EntryPoint = "__triangulation_MOD_neymanmethod", CallingConvention = CallingConvention.Cdecl)]
        public static extern int NeymanMethod(ref double a, ref double b);

        [DllImport("TriangleDistrDLL.dll", EntryPoint = "__triangulation_MOD_metropolysmethoditerable", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MetropolysMethod(ref double a, ref int x);

        [DllImport("TriangleDistrDLL.dll", EntryPoint = "__triangulation_MOD_calcmedian", CallingConvention = CallingConvention.Cdecl)]
        public static extern int CalcMedian(ref double a);

    }
}
