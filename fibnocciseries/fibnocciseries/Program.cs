﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibnocciseries
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            FibonocciSeries fibonocci = new FibonocciSeries();
            Console.ReadLine();
            fibonocci.FindFibonocciSeries();
        } 
    }
}
