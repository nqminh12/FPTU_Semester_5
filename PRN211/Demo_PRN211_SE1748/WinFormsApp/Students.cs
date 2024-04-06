using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class Students
    {
        public String Code { get; set; }
        public String Name { get; set; }
        public String Subject { get; set; }
        public int Mark { get; set; }

        public Students()
        {
        }

        public Students(string code, string name, string subject, int mark)
        {
            Code = code;
            Name = name;
            Subject = subject;
            Mark = mark;
        }

        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + Subject + "\t" + Mark;
        }



    }
}
