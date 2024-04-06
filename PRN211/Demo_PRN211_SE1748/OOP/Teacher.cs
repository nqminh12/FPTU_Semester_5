using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Teacher
    {
        //prop
        public string Code { get; set; }

        // propfull
        private string _name;

        public string Name
        {
            get { return _name; } // nếu gõ chữ "Name" 
            set { _name = value; }// nếu gõ chữ "Name = giá trị"
        }

        //Constructor

        //ctor
        public Teacher()
        {
        }

        public Teacher(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + GetSalary();
        }

        // tạo abstract method GetSalary
        public abstract double GetSalary();
    }
}
