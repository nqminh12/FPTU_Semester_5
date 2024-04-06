using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Common
    {
        public static int InputInt(String mess)
        {
            Console.WriteLine(mess);
            int n;
            do
            {
                try
                {
                    
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("n invalid");

                }
            } while (true);
            return n;
        }

        public static bool IsPalindrome(int num)
        {
            string numStr = num.ToString();
            char[] charArray = numStr.ToCharArray();
            Array.Reverse(charArray);
            string reversedNumStr = new string(charArray);
            return numStr == reversedNumStr;
        }

        public static void PrintPalindromes(int n, int m)
        {
            Console.WriteLine($"Cac so palindrome tu {n} den {m}:");
            for (int i = n; i <= m; i++)
            {
                if (IsPalindrome(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static int CountThreeDigitNumbers(int n, int m)
        {
            int count = 0;
            for (int i = n; i <= m; i++)
            {
                // Kiểm tra xem số có 3 chữ số không
                if (i >= 100 && i <= 999)
                {
                    count++;
                }
            }
            return count;
        }

        public static bool AllDigitsEven(int num)
        {
            string numStr = num.ToString();
            foreach (char c in numStr)
            {
                int digit = c - '0'; // Chuyển ký tự số về số nguyên
                if (digit % 2 != 0) // Kiểm tra chẵn lẻ
                {
                    return false;
                }
            }
            return true;
        }

         public static void DisplayNumbersWithEvenDigits(int n, int m)
        {
            Console.WriteLine($"Cac so co cac chu so la so chan tu {n} den {m}:");
            for (int i = n; i <= m; i++)
            {
                if (AllDigitsEven(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Hàm tính tổng các ước số chung của cả n và m
        public static int SumOfCommonDivisors(int n, int m)
        {
            int gcd = GCD(n, m);
            int sum = 0;
            for (int i = 1; i <= gcd; i++)
            {
                if (gcd % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
