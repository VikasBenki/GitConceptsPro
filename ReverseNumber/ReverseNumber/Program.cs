using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a Num");
            int num = Convert.ToInt32(Console.ReadLine());
            Reversenumber.GetReverse(num);
        }
    }
}
