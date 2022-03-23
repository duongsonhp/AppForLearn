using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class UserDefinedException3 : Exception
    {
        public UserDefinedException3() : base() { }
        public UserDefinedException3(string message) : base(message) { }
        public UserDefinedException3(string message, Exception exception) : base(message, exception) { }
        protected UserDefinedException3(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
