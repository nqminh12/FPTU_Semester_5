using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class Subjects
    {
        public Subjects()
        {
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "String is empty")]
        public String Code { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "String is empty")]
        public String Name { get; set; }
        [Range(5,20)]
        public int Slot { get; set; }

        public Subjects(string code, string name, int slot)
        {
            Code = code;
            Name = name;
            Slot = slot;
        }

        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + Slot;
        }
    }
}
