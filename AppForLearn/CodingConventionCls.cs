using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForLearn
{
    public class CodingConventionCls
    {
        public string @class { get; set; }

        public string school { get; set; }

        public string name { get; set; }

        public string id { get; set; }

        public CodingConventionCls(string @class, string school, string name, string id)
        {
            this.@class = @class;
            this.school = school;
            this.name = name;
            this.id = id;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"My name is {name}. My student id is {id}. I'm studying at class {@class} (school {school})");
        }
    }
}
