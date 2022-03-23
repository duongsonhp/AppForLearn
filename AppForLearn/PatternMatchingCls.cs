using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class Product
    {
        public string ProductName { get; set; }

        public double Price { get; set; }

        public string Manufacture { get; set; }

        public string Factory { get; set; }

        public Product(string ProductName, double Price, string Manufacture, string Factory)
        {
            this.ProductName = ProductName;
            this.Price = Price;
            this.Manufacture = Manufacture;
            this.Factory = Factory;
        }
    }

    public class PatternMatchingCls
    {
        public bool CheckNull(int? checkNum)
        {
            if(checkNum is int num)
            {
                Console.WriteLine($"checkNum = {num}");
                return false;
            }
            else
            {
                Console.WriteLine($"checkNum = null");
                return true;
            }
        }

        public bool CheckNullVer2(int? checkNum)
        {
            if (checkNum is not null)
            {
                Console.WriteLine($"checkNum = {checkNum.Value}");
                return false;
            }
            else
            {
                Console.WriteLine($"checkNum = null");
                return true;
            }
        }

        public bool CheckTypeDouble(dynamic value)
        {
            if (value is double temp)
            {
                Console.WriteLine($"value = {value}");
                return true;
            }
            else if (value is null)
            {
                Console.WriteLine($"value is null");
                return true;
            }
            else
            {
                Console.WriteLine($"value is not a double");
                return false;
            }
        }

        public bool CheckTypeDoubleVer2(dynamic value)
        {
            //if (value is double temp)
            //{
            //    Console.WriteLine($"value = {value}");
            //    return true;
            //}
            //else if (value is null)
            //{
            //    Console.WriteLine($"value is null");
            //    return true;
            //}
            //else
            //{
            //    Console.WriteLine($"value is not a double");
            //    return false;
            //}
            return value switch
            {
                double => true,
                null => false,
                _ => false
            };
        }

        public string CheckEquality(string value)
        {
            return value switch
            {
                "Hải Phòng" => "Thành phố lớn thứ 3 Việt Nam",
                "Hà Nội" => "Thủ đô Việt Nam",
                "TP. Hồ Chí Minh" => "Trung tâm kinh tế cả nước",
                "Cần Thơ" => "Trung tâm kinh tế, văn hóa, giáo dục của vùng Tây Nam Bộ",
                "Đà Nẵng" => "Trung tâm kinh tế, văn hóa, giáo dục của miền Trung",
                _ => "Các tỉnh khác",
            };
        }

        public string CheckEquality(double value)
        {
            return value switch
            {
                < 2 when (2 > 1) => "Yếu",
                >= 2 and < 5 => "Kém",
                >= 5 and < 6.5 => "Trung bình",
                >= 6.5 and < 8 => "Khá",
                >= 8 and < 9.5 => "Giỏi",
                _ => "Xuất sắc",
            };
        }

        public string CheckEquality(object value)
        {
            return value switch
            {
                Product { Manufacture: "Trung Quốc", Price: < 200000} when (2 > 1) => "Hàng cấp thấp",
                Product { Factory: "GuangZhou" } => "Nhà máy ở Quảng Châu",
                null => "Giá trị null",
                var obj => "Không thể check sản phẩm",
            };
        }
    }
}
