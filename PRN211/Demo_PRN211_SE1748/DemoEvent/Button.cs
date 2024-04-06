
namespace DemoEvent
{
    internal class Button
    {
        public Button(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        // Đây là hàm mô phỏng thao tác nhấn chuột 
        // Vậy nhấn chuột thì event nào xảy ra?
        // Sẽ được viết trong hàm click()
        internal void click()
        {
            if(OnClick != null)// Tức là button được gán sự kiện Onclick 
            {
                OnClick(Name);
            }
            else
            {
                Console.WriteLine("Button " + Name + " da gan event dau!");
            }
        }

        // Tạo event sẽ xảy ra khi nhấn chuột (gọi hàm click())
        public delegate void handle(string name);
        public event handle OnClick;
    }
}