using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    interface IInterface2
    {
        public int Property1
        {
            get { return 190; }
            set { }
        }

        string this[string index]
        {
            get { return index; }
            set { }
        }
    }
}
