using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    public class Manager : IManager
    {
        public Manager(List<Teacher> data)
        {
            Data = data;
        }

        public List<Teacher> Data { get; set; }

        public void CheckTeacher()
        {
            int flag = 0;
            foreach (Teacher t in Data)
            {
                if (t.Name.Trim().StartsWith("T"))
                {
                    flag = 1;
                    Console.WriteLine(t.Name + " " + t.GetSalary());
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Not found!");
            }
        }

        public int CountSlot10()
        {
            int count = 0;
            foreach (Teacher item in Data)
            {
                if (item is PartTimeTeacher && ((PartTimeTeacher)item).Slot == 10)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountSlotMoreThan10()
        {
            int count = 0;
            foreach (Teacher item in Data)
            {
                if (item is PartTimeTeacher && ((PartTimeTeacher)item).Slot > 10)
                {
                    count++;
                }
            }
            return count;
        }

        public void DisplaysAListOfFulltimeTeachers()
        {
            Console.WriteLine("{0,-15} {1,-15}", "First Name", "Last Name");
            foreach (Teacher item in Data)
            {
                if (item is FullTimeTeacher && ((FullTimeTeacher)item).Heso < 3)
                {
                    string[] names = item.Name.Split(' ');
                    if (names.Length > 1)
                    {
                        string firstName = names.First();
                        string lastName = names.Last();
                        // string middleName = string.Join(" ", names.Skip(1).Take(names.Length - 2));
                        Console.WriteLine("{0,-15} {1,-15}", firstName, lastName);
                    }
                }
            }
        }

        public void HighestSalaryTeacher()
        {
            var highestSalary = Data.Max(t => t.GetSalary());
            var highestSalaryTeachers = Data.Where(t => t.GetSalary() == highestSalary);

            foreach (var teacher in highestSalaryTeachers)
            {
                Console.WriteLine(teacher);
            }
        }

        public void InputList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter code: ");
                string code = Console.ReadLine();
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();
                int option = Common.InputInt("May la loai gv nao?0-full, 1-part:");
                Teacher T;
                if (option == 0)
                {
                    Console.WriteLine("Enter heso: ");
                    double heso = Convert.ToDouble(Console.ReadLine());
                    T = new FullTimeTeacher(code, name, heso);
                }
                else
                {
                    int slot = Common.InputInt("Enter slot: ");
                    T = new PartTimeTeacher(code, name, slot);
                }
                Data.Add(T);
            }
        }

        public void LoadFile()
        {
            Data.Clear();
            try
            {
                string filename = @"..\\..\\..\\data.txt";

                using (StreamReader sr = new StreamReader(filename))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        //2. Trong file mà có dòng trống thì bỏ qua dòng đó
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            line = sr.ReadLine();
                            continue;
                        }

                        // Add những thông tin này vào data
                        string[] s = line.Split("\t");
                        string code = s[0];
                        string name = s[1];
                        Teacher T;

                        //1. Nếu trong file có 1 dòng mà có code trùng thì không load dòng đó
                        if (Data.Any(teacher => teacher.Code == code))
                        {
                            line = sr.ReadLine();
                            continue;
                        }

                        //3. Trong file mà có dòng sai format thì bỏ qua dòng đó
                        if (s.Length < 4 || !s[3].Equals("0") && !s[3].Equals("1"))
                        {
                                line = sr.ReadLine();
                                continue;
                        }

                        Console.WriteLine(line);

                        if (s[3].Equals("0"))
                        {
                            double heso = Double.Parse(s[2]) / 2000000;
                            T = new FullTimeTeacher(code, name, heso);
                        }
                        else
                        {
                            int slot = int.Parse(s[2]) / 50000;
                            T = new PartTimeTeacher(code, name, slot);
                        }
                        Data.Add(T);

                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("LoadFile fail: " + ex.Message);
            }
        }

        public void OutputList()
        {
            foreach (Teacher item in Data)
            {
                Console.WriteLine(item);
            }
        }

        public void SaveFile()
        {
            try
            {
                string filename = @"..\\..\\..\\data.txt";

                /* Cach 1:
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine("Oke nhe anh em!!!");
                sw.Close();
                */

                // Cach 2:
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (Teacher item in Data)
                    {
                        if (item is FullTimeTeacher)
                        {
                            sw.WriteLine(item + "\t0");
                        }
                        else
                        {
                            sw.WriteLine(item + "\t1");
                        }
                    }
                }
                Console.WriteLine("Successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SaveFile fail: " + ex.Message);
            }

        }

        public void SortTeacher()
        {
            Data.Sort((t1, t2) => t1.GetSalary().CompareTo(t2.GetSalary()));
            Console.WriteLine("Sort complete!");
        }

        public int TotalNumberPartTimeTeacher()
        {
            int count = 0;
            foreach (Teacher item in Data)
            {
                if (item is PartTimeTeacher)
                {
                    count += ((PartTimeTeacher)item).Slot;
                }
            }
            return count;
        }

    }
}
