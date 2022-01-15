using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Reversenumber
    {
        public static void GetReverse(int n)
        {
            Console.WriteLine("enter a Num");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0, rem;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
            Console.ReadLine();
        }
    }
}
