using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    public class SwapingNumbers
    {
        public static void SwapingNumber()
        {
            int firstNum, secondNum, temp = 0;
            Console.WriteLine("enter the first NUM");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the second Num");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("before swaping values: firstNm ={0} secondNum={1}", firstNum, secondNum);
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("after swaping values firstNum={0}, secondNum={1}", firstNum, secondNum);
            Console.ReadLine();
        }
    }
}
