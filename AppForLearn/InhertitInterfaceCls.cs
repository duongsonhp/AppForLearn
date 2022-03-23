using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class InhertitInterfaceCls : IInterface1, IInterface2
    {
        public string Property2
        {
            get { return $"Return Property2"; }
        }

        int IInterface1.Property1
        {
            get { return FieldInt1; }
            set { FieldInt1 = 2 * value; }
        }

        //int IInterface2.Property1
        //{
        //    get { return FieldInt2; }
        //    set { FieldInt2 = value; }
        //}

        int IInterface1.Sub1(int num)
        {
            return num - 2;
        }

        public int FieldInt1;
        public int FieldInt2;
        public string FieldString1;
        public string FieldString2;
        public int DefautInt1;
        public int DefautInt2;
        public string DefaultString1;
        public string DefaultString2;

        public event EventHandler handler;

        public int this[int index]
        {
            get { return DefautInt1; }
            set { DefautInt1 = value; }
        }

        string IInterface2.this[string index]
        {
            get { return DefaultString2; }
            set { DefaultString2 = value; }
        }

        public int Add1(int num)
        {
            return num + 1;
        }

        public int Mul2(int num)
        {
            return 2 * 2 * num;
        }
    }
}
