using OOP;
namespace Language;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //khai báo và khởi tạo 1 biến số nguyên
        int n = 18;
        Console.WriteLine("n = " + n);//crtl + k + d để format code

        //Kiểm tra xem n là số chẵn hay lẻ
        if (n % 2 == 0)
        {
            Console.WriteLine("n la so chan");
        }
        else 
        {
            Console.WriteLine("n la so le");
        }


        //Practice
        int num;
        // nhap so nguyen n, nhap sai thi nhap lai den khi nao dung thi thoi
        num = Common.InputInt("Nhap so nguyen n:");




        // 1. kiểm tra xem n có phải snt không?


        if (checkPrime(num))
        {
            Console.WriteLine($"{num} la so nguyen to");
        }
        else
        {
            Console.WriteLine($"{num} ko phai la so nguyen to");
        }
        // 2. Có bn số chính phương tuywf 1 đến n
        int i;
        int count = 0;
        for (i = 1; i < num; i++)
        {
            if (checkSquare(i))
            {
                count++;
            }
        }

        Console.WriteLine($"co {count} so chinh phuong tu 1 den {num}");
        // 3. Hiển thị n hợp số > n
        Console.WriteLine($"Hop so");
        
        i = num + 1;
        count = 0;
        while (count < num)
        {
            
            if (!checkPrime(i))
            {
                Console.Write(i + " ");
                count++;
            }
            i++;
        }

        // nhap 1 so nguyen m tu ban phim sai thi nhap lai cho dung
        // muon dung Hàm InputInt()
        Console.WriteLine();
        int m = Common.InputInt("Nhap so nguyen m: ");


        // 1. HIện thị những số palindrom từ n đến m
        Common.PrintPalindromes(num, m);
        // 2. Có bao nhiêu số có 3 chữ số từ n đến m
        Console.WriteLine();
        Console.WriteLine($"Co {Common.CountThreeDigitNumbers(num, m)} so tu {num} den {m}");
        // 3. Hiển thị những số mà các chữ số tạo nên nó đều chẵn từ n đến m 
        Common.DisplayNumbersWithEvenDigits(num, m);
        // 4. Tìm tổng các số là ước chung của cả n và m
        Console.WriteLine();
        Console.WriteLine($"Tong cac so la uoc chung cua ca {n} va {m} la: {Common.SumOfCommonDivisors(num, m)}");
        //Yêu cầu: mỗi yêu cầu trên ít nhất tạo 1 hàm




    }

    

    public static Boolean checkPrime(int n)
    {
        if(n < 2) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static Boolean checkSquare(int n)
    {
        double squareRoot = Math.Sqrt(n);
        return squareRoot % 1 == 0;
    }

}