using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Customer
    {
        public string code { get; set; }
        public string name { get; set; }
        public bool gender { get; set; }
        public DateTime dob { get; set; }

        public Customer()
        {
        }

        public Customer(string code, string name, bool gender, DateTime dob)
        {
            this.code = code;
            this.name = name;
            this.gender = gender;
            this.dob = dob;
        }

        public override string? ToString()
        {
            return code + ";" + name + ";" + gender + ";" + dob;
        }
    }
}
