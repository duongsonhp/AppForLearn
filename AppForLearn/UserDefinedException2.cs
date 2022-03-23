using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class UserDefinedException2 : UserDefinedException1
    {
        public UserDefinedException2() : base() { }
        public UserDefinedException2(string message) : base(message) { }
        public UserDefinedException2(string message, Exception exception) : base(message, exception) { }
        protected UserDefinedException2(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
