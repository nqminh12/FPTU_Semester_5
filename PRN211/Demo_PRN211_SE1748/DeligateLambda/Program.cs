namespace DeligateLambda
{
    internal class Program
    {
        // tạo delegate
        delegate void MyDelegate1(int a, int b);
        delegate int MyDelegate2(int a);

        static void Main(string[] args)
        {
            Console.WriteLine("Before using delegate:");
            Cong(4, 6);
            UCLN(4, 6);
            SoSanh(4, 6);


            Console.WriteLine("After using delegate:");
            //c1: Tạo ra delegate
            MyDelegate1 d1 = new MyDelegate1(Cong);
            d1 += UCLN;
            d1 += SoSanh;

            d1 -= UCLN;
            d1(24, 6);
            d1(4, 6);

            //c2: tạo ra delegate
            MyDelegate2 d2 = delegate (int a)
            {
                return a * a;
            };
            Console.WriteLine("a * a = " + d2(5));

            //Biến hình c2 thành biểu thức lambda
            MyDelegate2 d3 = (int a) => a * a;
            Console.WriteLine("a*a=" + d3(5));

            // biến hình tiếp
            MyDelegate2 d4 = a => a * a;
            Console.WriteLine("a*a=" + d4(2));
        }

        public static void Cong(int a, int b)
        {
            Console.WriteLine("a + b = " + (a + b));
        }

        public static void UCLN(int m, int n)
        {
            while (m != n)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }
            Console.WriteLine("UCLN= " + m);
        }

        public static void SoSanh(int k, int l)
        {
            if (k == l) Console.WriteLine("K = l");
            if (k < l) Console.WriteLine("K < l");
            if (k > l) Console.WriteLine("K > l");
        }

    }
}
