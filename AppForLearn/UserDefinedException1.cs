using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class UserDefinedException1 : Exception
    {
        public UserDefinedException1() : base() { }
        public UserDefinedException1(string message) : base(message) { }
        public UserDefinedException1(string message, Exception exception) : base(message, exception) { }
        protected UserDefinedException1(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
