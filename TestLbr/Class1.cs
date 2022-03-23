using System;

namespace TestLbr
{
    public class AccessModifierCls
    {
        protected int TotalProducts;

        private protected void PrintSlogan()
        {
            Console.WriteLine("Try your best, the rest will come!");
        }

        //internal protected void PrintSlogan()
        //{
        //    Console.WriteLine("Try your best, the rest will come!");
        //}
    }

    public class InheritCls : AccessModifierCls
    {
        public int TotalImportProducts
        {
            get { return TotalProducts + 100; }

            set { TotalProducts = value; }
        }

        public void PrintNewSlogan()
        {
            PrintSlogan();
            Console.WriteLine("Do it now!");
        }
    }
}
