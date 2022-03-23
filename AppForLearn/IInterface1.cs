using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    interface IInterface1
    {
        int this[int index]
        {
            get;
            set;
        }

        public string Property2
        {
            get { return "Get Property2"; }
            set { }
        }

        public int Property1
        {
            get;
            set;
        }

        public virtual int Mul2(int num)
        {
            return 2 * num;
        }

        public static string DefaultStaticField = "Default static field";

        public string Property3
        {
            get { return "Get Property2"; }
            set { DefaultStaticField = value; }
        }

        string this[string index]
        {
            get { return index; }
            set { DefaultStaticField = value; }
        }

        public event EventHandler handler;

        public int Add1(int num);

        public int Sub1(int num)
        {
            return num - 1;
        }


    }


}
