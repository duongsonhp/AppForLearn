using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class DeconstructCls
    {
        public int Int1 { get; set; }
        public int Int2 { get; set; }
        public int Int3 { get; set; }
        public int Int4 { get; set; }

        public DeconstructCls(int Int1, int Int2, int Int3, int Int4)
        {
            this.Int1 = Int1;
            this.Int2 = Int2;
            this.Int3 = Int3;
            this.Int4 = Int4;
        }

        public void Deconstruct(out int Int1, out int Int2, out int Int3)
        {
            Int1 = this.Int1;
            Int2 = this.Int2;
            Int3 = this.Int3;
        }
    }
}
