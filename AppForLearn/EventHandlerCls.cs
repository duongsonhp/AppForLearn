using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class EventHandlerCls<T>
    {
        public delegate T Handler(object obj, EventArgs args);
        public delegate T1 Handler2<T1>(object obj, EventArgs args);
        public T ReturnValue;

        public event Handler Event;
        public void FireEvent()
        {
            if(Event != null)
            {
                ReturnValue = Event.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
