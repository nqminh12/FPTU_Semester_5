using OOP;

namespace DemoEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mô phỏng 1 bài toán như sau
            // Trên ứng dụng Console, chúng ta có 3 button: ASA, HIRU, BAN
            // Tưởng tượng là ta sẽ nhân nút nào đấy 
            // Nhấn nút nào thì phát ra câu chào tường ứng 

            //Tạo 3 nút đi ạ
            Button btnAsa = new Button("ASA");
            Button btnHiru = new Button("HIRU");
            Button btnBan = new Button("BAN");

            // Gán sự kiện cho 3 nút
            btnAsa.OnClick += Btn_OnClick;
            btnHiru.OnClick += Btn_OnClick;
            btnBan.OnClick += Btn_OnClick;


            while (true)
            {
                Console.WriteLine("1.Button ASA.");
                Console.WriteLine("2.Button HIRU.");
                Console.WriteLine("3.Button BAN.");
                int option = Common.InputInt("Please click a button(1,2,3):");
                switch (option) {
                    case 1:
                        {
                            //Mô phỏng nhấn nút ASA
                            btnAsa.click();
                            break;
                        }
                    case 2:
                        {
                            btnHiru.click();
                            break;
                        }
                    case 3:
                        {
                            btnBan.click();
                            break;
                        }
                }
            }
        }

        private static void Btn_OnClick(string name)
        {
            Console.WriteLine("May vua nhan button " + name);
        }

        
    }
}
