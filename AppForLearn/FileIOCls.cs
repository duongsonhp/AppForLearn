using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class FileIOCls
    {
        public void WriteFile()
        {
            var stream = new StreamWriter("D:\\Users\\duong\\source\\repos\\AppForLearn\\AppForLearn\\TestTextFile.txt");
            try
            {
                stream.WriteLine("Công ti cổ phần Tập đoàn công nghệ BKAV");
                stream.WriteLine("Tòa nhà HH1, KĐT Yên Hòa, P.Yên Hòa, Q.Cầu Giấy, TP.Hà Nội");
                var a = 1;
                var b = 0;
                var c = a / b;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception message is '{ex.Message}'");
            }
            finally
            {
                Console.WriteLine($"Finally: Close stream");
                stream?.Close();
            }
        }

        public void WriteFile2(out StreamWriter _stream)
        {
            using var stream = new StreamWriter("D:\\Users\\duong\\source\\repos\\AppForLearn\\AppForLearn\\TestTextFile.txt");
            _stream = stream;
            stream.WriteLine("Công ti cổ phần Tập đoàn công nghệ BKAV");
            stream.WriteLine("Tòa nhà HH1, KĐT Yên Hòa, P.Yên Hòa, Q.Cầu Giấy, TP.Hà Nội");
        }

        public void WriteFile(string fileName)
        {
            var stream = new StreamWriter(fileName);
            try
            {
                stream.WriteLine("Công ti cổ phần Tập đoàn công nghệ BKAV");
                stream.WriteLine("Tòa nhà HH1, KĐT Yên Hòa, P.Yên Hòa, Q.Cầu Giấy, TP.Hà Nội");
                var a = 1;
                var b = 0;
                var c = a / b;
            }
            catch (Exception ex) when (fileName == "D:\\Users\\duong\\source\\repos\\AppForLearn\\AppForLearn\\TestTextFile.txt")
            {
                Console.WriteLine($"Exception message when write file TestTextFile is '{ex.Message}'");
            }
            catch (Exception ex) when (fileName != "D:\\Users\\duong\\source\\repos\\AppForLearn\\AppForLearn\\TestTextFile.txt")
            {
                Console.WriteLine($"Exception message when write another file is '{ex.Message}'");
            }
            finally
            {
                Console.WriteLine($"Finally: Close stream");
                stream?.Close();
            }
        }

        public void CalculateDivide(int a, int b)
        {
            try
            {
                Console.WriteLine($"a / b = {a} / {b} = {a / b}");
                int? c = null;
                int d = c.Value;
            }
            catch(Exception ex) when (PrintException(ex))
            {

            }
        }

        public bool PrintException(Exception exception)
        {
            Console.WriteLine($"Exception: {exception.Message}");
            return false;
        }
    }
}
