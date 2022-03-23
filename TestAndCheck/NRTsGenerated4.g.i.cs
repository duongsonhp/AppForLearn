using System.Diagnostics.CodeAnalysis;
/// <summary>
/// * Phục vụ mục đích kiểm thử các kỹ thuật
/// * Bài học: Nullable Reference Types (Kiểu tham chiếu nullable)
/// * Link: https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references#nullable-contexts
/// </summary>
namespace TestAndCheckGenerated4
{
    /// <summary>
    /// * Lớp này giả định là một lớp thuộc một thư viện bên ngoài, không trực tiếp truy cập vào được các thành phần của lớp
    /// </summary>
    public class External
    {
        /// <summary>
        /// Phương thức kiểm tra not-null cần được mở rộng
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool CheckNotNullExternal(int? number)
        {
            if (number.HasValue == true)
            {
                return true;
            }
            return false;
        }
    }

    // TH 1: Test không đánh dấu API kiểm tra null
    // TH 2: Test đánh dấu API kiểm tra null cho phương thức
    // TH 3: Test đánh dấu API kiểm tra null cho phương thức mở rộng
    public class NRTs
    {
        public int? validatedInteger { get; set; }

        // Kiểm tra khai báo nullable - Hợp lệ trong chế độ enable
        public Inner? innerInstance { get; set; }

        public Inner notNullableInnerInstance { get; set; }

        // public int testNotNullableInteger { get; set; }

        /// <summary>
        /// Phương thức kiểm tra not-null
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool CheckNotNullNormal(int? number)
        {
            if (number.HasValue == true)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Phương thức kiểm tra not-null được đánh dấu để compiler nhận biết
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool CheckNotNullMarked([NotNullWhen(true)] int? number)
        {
            if(number.HasValue == true)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Phương thức kiểm tra not-null bằng cách sử dụng phương thức của thư viện ngoài
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool CheckNotNullFromExternal([NotNullWhen(true)] int? number)
        {
            return External.CheckNotNullExternal(number);
        }

        public void ExecuteTest()
        {
            #region Hiển thị cảnh báo trong trường hợp dùng hàm check null
            // Phương thức check not-null không được đánh dấu
            if (CheckNotNullNormal(validatedInteger))
            {
                Console.WriteLine($"1. {validatedInteger.Value}");
            }

            // Phương thức check not-null được đánh dấu
            if (CheckNotNullMarked(validatedInteger))
            {
                Console.WriteLine($"2. {validatedInteger.Value}");
            }

            // Phương thức check not-null được đánh dấu, gọi một phương thức check not-null từ thư viện ngoài
            if (CheckNotNullFromExternal(validatedInteger))
            {
                Console.WriteLine($"3. {validatedInteger.Value}");
            }
            #endregion

            #region Kiểm tra các chế độ hiển thị cảnh báo
            #region annotations
            //// innerInstance tuy không được khởi tạo trong lớp, nhưng nó hoàn toàn có thể được khởi tạo từ bên ngoài class. Tuy nhiên, compiler vẫn giả định là nó maybe-null
            //Console.WriteLine($"innerInstance.integer = {innerInstance.integer}");
            #endregion

            #region warnings
            Console.WriteLine($"innerInstance.integer = {innerInstance.integer}");
            Console.WriteLine($"innerInstance.integer = {innerInstance!.integer}");
            #endregion

            #region enable 
            //// innerInstance tuy không được khởi tạo trong lớp, nhưng nó hoàn toàn có thể được khởi tạo từ bên ngoài class. Tuy nhiên, compiler vẫn giả định là nó maybe-null
            //Console.WriteLine($"innerInstance.integer = {innerInstance.integer}");
            //notNullableInnerInstance = null;
            #endregion

            #region disable
            //Console.WriteLine($"innerInstance.integer = {innerInstance.integer}");
            //Console.WriteLine($"innerInstance.integer = {innerInstance!.integer}");
            //notNullableInnerInstance = null;
            #endregion
            #endregion
        }

        public class Inner
        {
            public int integer { get; set; }
        }
    }
}

/* MỘT SỐ KIẾN THỨC
 * I) Các chế độ annotation và warning
 * ==disable== (Chế độ cấm hết tất cả: Không hiện cảnh báo, không cho khai báo nullable)
 * - Không hiện cảnh báo null hoặc cảnh báo gán null
 * - Không cho khai báo nullable
 * ==enable== (Chế độ quan tâm tới cả cảnh báo null dereference và cảnh báo gán null để đảm bảo gán giá trị khớp với khai báo nullable)
 * - Cho phép hiện cảnh báo null, gán null
 * - Cho phép khai báo nullable
 * - Cho phép bỏ null
 * ==warnings== (Chế độ mặc định nullable, vì chỉ quan tâm tới cảnh báo null dereference)
 * - Cho phép hiện cảnh báo null
 * - Cảnh báo khi khai báo nullable
 * - Mọi biến tham chiếu đều được xem như nullable (Để tiện cho việc cảnh báo null dereference)
 * - Không cảnh báo gán null (Vì mọi biến được xem như nullable)
 * ==annotation== (Chế độ chỉ quan tâm tới khai báo nullable)
 * - Không hiển thị bất cứ cảnh báo gì
 * - Cho phép khai báo nullable
 */