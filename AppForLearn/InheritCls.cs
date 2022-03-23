using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class ParentCls
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ParentCls(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public ParentCls(int Id, string Name, string Text) : this(Id, Name)
        {
            Console.WriteLine($"Print text '{Text}'");
        }

        public void Deconstruct(out int _Id, out string _Name)
        {
            _Id = Id;
            _Name = Name;
        }
    }

    public class ChildCls : ParentCls
    {
        public string Department { get; set; }

        public ChildCls(int Id, string Name, string Department) : base(Id, Name)
        {
            this.Department = Department;
        }

        public void Deconstruct(out int _Id, out string _Name, out string _Department)
        {
            _Id = Id;
            _Name = Name;
            _Department = Department;
        }
    }
}
