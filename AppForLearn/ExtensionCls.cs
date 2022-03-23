using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public static class ExtensionCls
    {
        public static void PrintString(this TheChildCls3 inst, string value)
        {
            Console.WriteLine($"Print value = {value}");
        }

        public static void Deconstruct(this DeconstructCls dcstr, out int Int1, out int Int2)
        {
            Int1 = dcstr.Int1;
            Int2 = dcstr.Int2;
        }
    }
}
