using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Security.Permissions;

namespace AppForLearn
{
    public class TestCls
    {
        public int Field1 { get; set; }

        public readonly int Field2 = 60;

        public readonly int Field3;

        public TestCls(int Int1, int Int3)
        {
            Field1 = Int1;
            Field3 = Int3;
        }
    }
}
