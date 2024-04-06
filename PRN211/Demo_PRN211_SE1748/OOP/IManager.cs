using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IManager
    {
        public void InputList(int size);

        public void OutputList();

        public int CountSlot10();

        public void SaveFile();

        public void LoadFile();

        public int TotalNumberPartTimeTeacher();

        public void SortTeacher();

        public void CheckTeacher();

        public void DisplaysAListOfFulltimeTeachers();

        public void HighestSalaryTeacher();

        public int CountSlotMoreThan10();
    }
}
