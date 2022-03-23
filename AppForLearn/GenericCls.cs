using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    // Generic sử dụng như là tham số của class
    // Generic sử dụng như là tham số phương thức
    // Generic sử dụng như là giá trị trả về của phương thức
    // Generic được sử dụng ở vị trí bất kì trong phương thức
    public class GenericCls<T>
    {
        public class NestedCls
        {
            public T propNested;

            public NestedCls(T para)
            {
                propNested = para;
            }
        }

        public T prop1;

        public GenericCls(T prop1)
        {
            this.prop1 = prop1;
        }

        public void PrintTest1(T para)
        {
            Console.WriteLine($"PrintTest1 - {para.ToString()}");
        }

        public T PrintTest2()
        {
            Console.WriteLine(prop1.ToString());
            return prop1;
        }
    }
}
