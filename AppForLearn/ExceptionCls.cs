using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class ExceptionCls
    {
        public void DevideByZero(int num)
        {
            try
            {
                var result = 1;
                var num2 = 0;
                Console.WriteLine($"Start Divide!");
                result = num / num2;
                Console.WriteLine($"Devided successfully! result = {result}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Failed! ex = {ex.Message}");
                throw;
            }
        }

        public int CalculateMultipleInt(int num1, int num2)
        {
            var result = 0;

            try
            {
                if (num1 < 10)
                {
                    throw new UserDefinedException3($"num1 = {num1} < 10", new UserDefinedException1($"Detail user-defined exception"));
                }
                else if(num1 < 20)
                {
                    throw new UserDefinedException2($"num1 = {num1} < 20");
                }
                result = num1 * num2;
            }
            catch(UserDefinedException2 ex2)
            {
                Console.WriteLine($"UserDefinedException2 - {ex2.Message}");
            }
            catch(UserDefinedException3 ex3)
            {
                Console.WriteLine($"UserDefinedException3 - {ex3.Message}");
                throw;
            }
            return result;
        }

        public int CalculateSum(int[] listInt, int count)
        {
            var result = 0;

            try
            {
                for (var i = 0; i < count; ++i)
                {
                    result += listInt[i];
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                throw new ArgumentException("Argument is invalid", nameof(count), ex);
            }
            return result;
        }
    }
}
