namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo 1 danh sách teahcer

            List<Teacher> data = new List<Teacher>()
            {
                new FullTimeTeacher("T01", "Nguyen Van A", 3),
                new PartTimeTeacher("T02", "Nguyen Van B", 11),
                new FullTimeTeacher("T03", "Nguyen Van C", 2),
                new PartTimeTeacher("T06", "Nguyen Van D", 12),
                new PartTimeTeacher("T07", "Nguyen Van E", 10),
                new FullTimeTeacher("T05", "Nguyen Van T", 1)
            };
            data.Add(new PartTimeTeacher("T04", "Nguyen Van F", 7));
            Manager m = new Manager(data);
            //Tạo menu
            while (true)
            {
                Console.WriteLine("1. Input list Teacher.");
                Console.WriteLine("2. Output list Teacher.");
                Console.WriteLine("3. Count PartTime have slot = 10");
                Console.WriteLine("4. Load data from file.");
                Console.WriteLine("5. Save data to file.");
                Console.WriteLine("6. Calculate the total number of parttime teacher's slots.");
                Console.WriteLine("7. Sort the list of teachers increased by salary.");
                Console.WriteLine("8. Teacher whose name starts with ‘T’");
                Console.WriteLine("9. Displays a list of fulltime teachers with the " 
                                  + "salary coefficient < 3.");
                Console.WriteLine("10. Teachers have the slot > 10.");
                Console.WriteLine("11. Highest salary teacher.");
                Console.WriteLine("0. Exit.");

                int option = Common.InputInt("Choose an option");
                switch (option)
                {
                    case 0:
                        return;
                    case 1:
                        {
                            int size = Common.InputInt("Enter size:");
                            m.InputList(size);
                            break;
                        }
                    case 2:
                        {
                            m.OutputList();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Count = " + m.CountSlot10());
                            break;
                        }
                    case 4:
                        {
                            m.LoadFile();
                            break;
                        }
                    case 5:
                        {
                            m.SaveFile();
                            break;
                        }
                    case 6:
                        {
                            int slot = m.TotalNumberPartTimeTeacher();
                            Console.WriteLine("Number of  parttime teacher's slots: " + slot);
                            break;
                        }
                    case 7:
                        {
                            m.SortTeacher();
                            break;
                        }
                    case 8:
                        {
                            m.CheckTeacher();
                            break;
                        }
                    case 9:
                        {
                            m.DisplaysAListOfFulltimeTeachers();
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Count = " + m.CountSlotMoreThan10());
                            break;
                        }
                    case 11:
                        {
                            m.HighestSalaryTeacher();
                            break;
                        }
                }
            }
        }
    }
}
