﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Quotes_in_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string first = @"The ""use"" of quotations causes difficulties";
            string second = "The \"use\" of quotations causes difficulties";
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
