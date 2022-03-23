using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class DelegateCls
    {
        public delegate int ReturnDouble(int num);

        public delegate void VoidMethod(string text);

        public int _ReturnDouble(int num) { return 2 * num; }

        public void PrintString(string text) { Console.WriteLine($"Print {text}"); }

        public Func<int, int> returnFunction = num => 2 * num;

        public Action<string> printText = text => Console.WriteLine($"Print {text}");

        public void MainMethod(int num, string text)
        {
            ReturnDouble returnMethod = _ReturnDouble;
            VoidMethod printMethod = PrintString;
            Console.WriteLine($"[1] Double of {num} is equal {returnMethod(num)}");
            Console.WriteLine($"[2] Double of {num} is equal {returnFunction(num)}");
            printMethod($"[1] {text}");
            printText($"[2] {text}");
        }
    }
}
