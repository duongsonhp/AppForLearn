using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public record RecordRcd(int _Int1, int _Int2);

    public record RecordRcdVersion2(int _Int1, int _Int2, int _Int3) : RecordRcd(_Int1, _Int2);

    public record RecordRcdVersion3(int _Int1, int _Int2, int _Int3) : RecordRcd(_Int1, _Int2);

    public record RecordRcd4(int _Int1, int _Int2, int _Int3);
    public record RecordRcd5(int _Int1, int _Int2, int _Int3);
}
