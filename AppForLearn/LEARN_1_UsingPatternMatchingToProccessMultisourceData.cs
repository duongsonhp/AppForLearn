using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegisterPrivateVehicle;
using RegisterTradeVehicle;

namespace RegisterPrivateVehicle
{
    public class Car
    {
        /// <summary>
        /// Ngày đăng kiểm
        /// </summary>
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// Số ghế
        /// </summary>
        public int Seats { get; set; }

        public Car(DateTime registerDate, int seats)
        {
            RegisterDate = registerDate;
            Seats = seats;
        }
    }

    public class Motorbike
    {
        /// <summary>
        /// Ngày đăng kiểm
        /// </summary>
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// Phân khối
        /// </summary>
        public int Cc { get; set; }
    }
}

namespace RegisterTradeVehicle
{
    public class TravelBus
    {
        /// <summary>
        /// Ngày đăng kiểm
        /// </summary>
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// Số chỗ
        /// </summary>
        public int Seats { get; set; }
    }

    public class Bus
    {
        /// <summary>
        /// Ngày đăng kiểm
        /// </summary>
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// Số chỗ
        /// </summary>
        public int Seats { get; set; }

        /// <summary>
        /// Có được trợ giá không?
        /// </summary>
        public bool IsSupportPrice { get; set; }

        /// <summary>
        /// Công ti sở hữu
        /// </summary>
        public string Owner { get; set; }
    }
}

namespace TollAuthoritySystem
{
    public class TollAuthority
    {
        /// <summary>
        /// Kiểm tra kiểu dữ liệu
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string ValidateDataType(object data)
        {
            return data switch
            {
                Car car => "Xe con",
                Motorbike motorbike => "Xe máy",
                TravelBus travelbus => "Xe du lịch",
                Bus bus => "bus nội đô",
                { } => "Kiểu khác",
                null => "Giá trị truyền vào null"
            };
        }

        /// <summary>
        /// Kiểm tra điều kiện của thuộc tính
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string ValidateConditionOfProperty(object data)
        {
            // var standardDate = new DateTime(2004, 1, 1);
            return data switch
            {
                Car { Seats: 4} => "Xe 4 chõ",
                Car { Seats: > 4, Seats: <=7 } => "Xe nhỏ hơn 7 chỗ",
                Car car when (car.RegisterDate > new DateTime(2004, 1, 1)) => "Đăng kiểm sau 1/1/2004",
                Motorbike { Cc: > 50} => "Xe lớn hơn 50 phân khối",
                TravelBus { Seats: < 24 } => "Xe du lịch nhỏ hơn 24 chỗ",
                Bus { Owner: "Liên Ninh"} => "Xe Liên Ninh",
                Bus { Owner: "10-10" } => "Xe 10-10",
                Bus { IsSupportPrice: false } => "Không được trợ giá",
                { } => "Kiểu khác",
                null => "Giá trị truyền vào null"
            };
        }

        /// <summary>
        /// Kiểm tra bộ điều kiện của bộ biến
        /// </summary>
        /// <param name="Seats"></param>
        /// <param name="Owner"></param>
        /// <param name="IsSupportPrice"></param>
        /// <returns></returns>
        public string ValidateTupleCondition(int Seats, string Owner, bool IsSupportPrice)
        {
            return (Seats, Owner, IsSupportPrice) switch
            {
                (24, "Bảo Yến", true) => "Xe Bảo Yến 24 chỗ, có trợ giá",
                (29, "Bắc Hà", false) => "Xe Bắc Hà 29 chỗ, không trợ giá",
                _ => "Khác"
            };
        }
    }
}
