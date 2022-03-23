using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using TestLbr;
using System.Text;
using System.IO;
using RegisterPrivateVehicle;
using RegisterTradeVehicle;
using TollAuthoritySystem;
using TestAndCheck;

namespace AppForLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            #region Test bất đồng bộ
            //var asyncObj = new AsynchronousCls();
            //asyncObj.LoadingPre();
            #endregion

            #region Test tham số dòng lệnh
            //Console.WriteLine($"{args[0]} * {args[1]} = {Convert.ToDouble(args[0]) * Convert.ToDouble(args[1])}");

            //var program = new Program();
            //program.PrintArgs();
            //program.PrintArgs2();
            //program.PrintArgs3(args);
            #endregion

            #region Test exit code
            //var exitCodeObj = new ExitCodeCls(@"D:\Users\duong\source\repos\ReferencedApp\ReferencedApp\bin\Debug\net5.0\ReferencedApp.exe");
            //exitCodeObj.PrintExitCode2();
            #endregion

            #region Test interface
            //var program = new Program();
            //IInterface1 inheritInterfaceObj1 = new InhertitInterfaceCls();
            #endregion

            #region Test event handler
            //// var program = new Program();
            //var ev = new EventHandlerCls<int>();

            //// ev.Event += program.Print;
            //ev.Event += (object obj, EventArgs args) =>
            //{
            //    Console.WriteLine("Test event handler");
            //    return 0;
            //};
            //ev.FireEvent();
            #endregion

            #region Test record
            //RecordRcd rcd1 = new RecordRcd(10, 11);
            //var (ele1, ele2) = rcd1;
            //Console.WriteLine($"ele1 = {ele1}, ele2 = {ele2}");
            ////RecordRcdVersion2 rcd2 = new RecordRcdVersion2(13, 15, 19);
            //RecordRcd rcd2 = new RecordRcd(13, 15);
            //RecordRcd rcd3 = rcd2 with { _Int1 = 25 };
            //Console.WriteLine(rcd3);
            #endregion

            #region Test generic
            //var genObj = new GenericCls<int>(13);
            //genObj.PrintTest1(15);
            //genObj.PrintTest2();
            #endregion

            #region Test kiểu ẩn danh
            ////var program = new Program();
            ////Console.WriteLine(program.TestReturnAnonymous().Prop1);

            //var program = new Program();
            //var obj = new { Prop1 = 21, Prop2 = 71 };
            //var obj2 = new { Prop1 = 21, Prop2 = 71 };
            //Console.WriteLine(obj.Equals(obj2));
            #endregion

            #region Test từ khóa yield
            //var program = new Program();
            //var lst = new List<int>() { 90, 81, 77, 231, 109, 111, 24 };
            //// Console.WriteLine(program.GetListInteger(lst).ToString());
            //var lst2 = program.GetListInteger(lst);
            //lst2.ToList().ForEach(delegate (int para)
            //{
            //    Console.WriteLine(para);
            //});
            #endregion

            #region Test lớp abstract
            //AbstractCls obj1 = new TheChildCls(14);
            //obj1.GetProperty();

            //TheChildCls obj2 = new TheChildCls2(14);
            //obj2.GetProperty();
            #endregion

            #region Test hiệu quả của từ khóa sealed
            //AbstractCls obj1 = new TheChildCls3(14);
            //TheChildCls obj2 = new TheChildCls3(14);
            //TheChildCls2 obj3 = new TheChildCls3(14);
            //TheChildCls3 obj4 = new TheChildCls3(14);

            //obj1.GetProperty();
            //obj2.GetProperty();
            //obj3.GetProperty();
            //obj4.GetProperty();
            #endregion

            #region Test partial class
            //var obj = new PartialCls();
            //obj.Int1 = 45;
            //obj.Int2 = 20;
            //obj.Print1();
            //obj.Print2();
            #endregion

            #region Test phương thức mở rộng
            //var obj = new TheChildCls3(14);
            //obj.PrintString($"SonDHe");
            #endregion

            #region Test so sánh class
            //var obj = new Test(47, 29, 147);
            //var obj2 = new Test(47, 29, 147);
            //Console.WriteLine(obj.Equals(obj2));
            #endregion

            #region Test hàm tạo static
            //var obj = new Test(70, 21, 44);
            //Console.WriteLine($"static = {Test.StaticField}");
            //Test.StaticField = 100;
            //Console.WriteLine($"static = {Test.StaticField}");
            //var obj2 = new Test(70, 21, 44);
            //Console.WriteLine($"static = {Test.StaticField}");

            #endregion

            #region Test access modifier
            //var obj = new InheritCls();
            //obj.PrintNewSlogan();

            #endregion

            #region Test pattern matching
            //var matchObj = new PatternMatchingCls();
            //// Kiểm tra null
            //matchObj.CheckNull(100);
            //matchObj.CheckNull(null);
            //matchObj.CheckNullVer2(290);
            //matchObj.CheckNullVer2(null);

            //// Kiểm tra kiểu double
            //Console.WriteLine(matchObj.CheckTypeDoubleVer2(323.21));
            //Console.WriteLine(matchObj.CheckTypeDoubleVer2(141));
            //Console.WriteLine(matchObj.CheckTypeDoubleVer2(null));
            //Console.WriteLine(matchObj.CheckTypeDoubleVer2("Other type"));

            //// Kiểm tra bằng - switch
            //// Console.WriteLine(matchObj.CheckEquality("Hà Nội"));
            //// Console.WriteLine(matchObj.CheckEquality(5.5));
            ////Console.WriteLine(matchObj.CheckEquality(new Product("Kem dưỡng da", 230000, "Trung Quốc", "Hongkong")));

            ////Product product = null;
            ////Console.WriteLine(matchObj.CheckEquality(product));
            #endregion

            #region Test tuple
            ////var tupple = new Tuple<int, int, string>(13, 35, "Test tuple");
            ////Console.WriteLine(tupple.ToString());

            //var tupple = (14, 31, "Last");

            //var output1 = 0;
            //var output2 = 0;
            //var output3 = "";
            //(output1, output2, output3) = tupple;
            //Console.WriteLine($"output1 = {output1}, output2 = {output2}, output3 = {output3}");



            //// program.PrintTuple(13, 40, 910);
            #endregion

            #region Test discard
            //////var decstr = new DeconstructCls(104, 32, 59, 44);
            //////var (_, int2, _) = decstr;
            //////Console.WriteLine($"int2 = {int2}");
            ////Console.WriteLine($"Convert 13.4 to int: {Int32.TryParse("13.4", out _)}");

            //var _ = 13;
            //Console.WriteLine(_);

            ////var discardObj = new DiscardCls();
            ////discardObj.PrintInteger(145);
            #endregion

            #region Test deconstruct
            ////var deconstructObj = new DeconstructCls(12, 90, 10, 28);
            ////var (int1, int2) = deconstructObj;
            ////Console.WriteLine($"int1 = {int1}, int2 = {int2}");

            //var dictionary = new Dictionary<int, double>()
            //{
            //    [12] = 32.4,
            //    [11] = 4.99,
            //    [2] = 10.56
            //};
            //foreach(var (key, value) in dictionary)
            //{
            //    Console.WriteLine($"key = {key} then value = {value}");
            //}
            #endregion

            #region Test exception
            //var exceptionObj = new ExceptionCls();
            //////exceptionObj.DevideByZero(1332);
            ////var fileIOObj = new FileIOCls();
            //////fileIOObj.WriteFile("D:\\Users\\duong\\source\\repos\\AppForLearn\\AppForLearn\\TestTextFile2.txt");
            ////fileIOObj.CalculateDivide(40, 1);

            //// exceptionObj.CalculateMultipleInt(4, 50);
            ////using(ChildCls testPage = new ChildCls("Parent", "3246", "Child", "9218"))
            ////{
            ////    Console.WriteLine("Initialize testPage");
            ////}

            ////ChildCls testPage = new ChildCls("Parent", "3246", "Child", "9218");
            ////Console.WriteLine("Don't need testPage");

            //exceptionObj.CalculateSum(new int[] { 13, 2, 57 }, 4);
            #endregion

            #region Test quy chuẩn viết code
            //var studentInfo = new CodingConventionCls("10A6", "THPT Thái Phiên", "Dương Hoàng Sơn", "20173579");
            //studentInfo.PrintInfo();

            //var delegateObj = new DelegateCls();
            //delegateObj.MainMethod(13, "Test 7/2/2022");

            //var file = new FileIOCls();


            //FileIOCls file = new();


            //StreamWriter _stream;
            //file.WriteFile2(out _stream);
            //if (_stream.BaseStream.CanWrite)
            //{
            //    Console.WriteLine("The stream hasn't been closed yet!");
            //}
            //else
            //{
            //    Console.WriteLine("The stream was closed!");
            //}
            #endregion

            #region Test kế thừa class
            //var inheritClassObj = new ChildCls(14, "Mark", "Facebook");
            //var (_Id, _Name, _Department) = inheritClassObj;
            //Console.WriteLine($"object.Id = {_Id}, object.Name = {_Name}, object.Department = {_Department}");
            #endregion

            #region Test chưa phân loại
            ////var testPg = new TestCls("Show something");
            ////Console.WriteLine($"12 ^ 3 = {TestCls.CalculatePower3(12)}");
            //var testObj = new Test();
            //testObj.Int = 212;
            //var testObj2 = testObj;
            //testObj.Int = 210;
            //Console.WriteLine(testObj2.Int);

            //var obj = new ParentCls(50, "Lee", "Back to school");
            //var (_Id, _Name) = obj;
            //Console.WriteLine($"obj.Id = {_Id}, obj.Name = {_Name}");

            //var testPageObj = new TestCls(56, 90);
            //Console.WriteLine($"Field1 = {testPageObj.Field1}, Field2 = {testPageObj.Field2}, Field3 = {testPageObj.Field3}");



            //var lst = new List<int>() { 21, 63, 90, 11 };
            //lst.ForEach(num => Console.WriteLine($"Item {num}"));

            NRTs.ExecuteTestDefaultOperator();
            #endregion


            Console.ReadKey();
        }

        void PrintArgs()
        {
            var arguments = Environment.GetCommandLineArgs();
            Console.WriteLine($"Command-line arguments are {String.Join(", ", arguments)}");
        }

        void PrintArgs2()
        {
            // var arguments = Environment.GetCommandLineArgs();
            Console.WriteLine($"Command-line arguments are {Environment.CommandLine}");
        }

        void PrintArgs3(string[] args)
        {
            // var arguments = Environment.GetCommandLineArgs();
            Console.WriteLine($"Command-line arguments are {String.Join(", ", args)}");
        }

        int Print(object obj, EventArgs args)
        {
            Console.WriteLine("Test event handler");
            return 0;
        }

        (int, int, int) PrintTuple(int Int1, int Int2, int Int3)
        {
            Console.WriteLine((Int1, Int2, Int3).ToString());
            return (Int1, Int2, Int3);
        }

        dynamic TestReturnAnonymous()
        {
            return new { Prop1 = 145, Prop2 = 245 };
        }

        void TestParamAnonymous(dynamic para)
        {
            Console.WriteLine(para.Prop1);
        }

        IEnumerable<int> GetListInteger(List<int> lst)
        {
            foreach(var item in lst)
            {
                yield return item;
            }
        }
    }

    //public class Test
    //{
    //    public static int StaticField;

    //    static Test()
    //    {
    //        StaticField = 0;
    //        Console.WriteLine("Invoke only once!");
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        if (Int1 == ((Test)obj).Int1 && Int2 == ((Test)obj).Int2 && Int3 == ((Test)obj).Int3)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }

    //    public int Int1;

    //    public int Int2;

    //    public int Int3;

    //    public Test(int Int1, int Int2, int Int3)
    //    {
    //        this.Int1 = Int1;
    //        this.Int2 = Int2;
    //        this.Int3 = Int3;
    //    }
    //}

    public class Test
    {
        public int Int;
    }
}
