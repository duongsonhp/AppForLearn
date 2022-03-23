using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public abstract class AbstractCls
    {
        public void GetProperty2()
        {
            Console.WriteLine($"GetProperty2 - 1");
        }

        public AbstractCls(int Property1)
        {
            this.Property1 = Property1;
        }

        protected int Property1 { get; set; }

        public virtual int GetProperty()
        {
            Console.WriteLine($"2 * Property1 = {2 * Property1}");
            return 2 * Property1;
        }
    }

    public class TheChildCls : AbstractCls
    {
        public override int GetProperty()
        {
            base.GetProperty();
            Console.WriteLine($"3 * Property1 = {3 * 5}");
            return 3 * 5;
        }

        public new void GetProperty2()
        {
            Console.WriteLine($"GetProperty2 - 2");
        }

        public TheChildCls(int Property1) : base(Property1) { }
    }

    public class TheChildCls2 : TheChildCls
    {
        public sealed override int GetProperty()
        {
            base.GetProperty();
            Console.WriteLine($"10 * Property1 = {10 * 5}");
            return 10 * 5;
        }

        public TheChildCls2(int Property1) : base(Property1) { }
    }

    public class TheChildCls3 : TheChildCls2
    {
        //public new int GetProperty()
        //{
        //    Console.WriteLine($"21 * Property1 = {21 * 5}");
        //    return 21 * 5;
        //}

        public TheChildCls3(int Property1) : base(Property1) { }
    }
}
