﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {

            int length = int.Parse(Console.ReadLine());

            int min = int.MaxValue;
            int max = int.MinValue;

            double sum = 0;
            double avg = 0;


            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(Console.ReadLine());

                //min
                min = Math.Min(min, number);

                //max
                max = Math.Max(max, number);

                //sum
                sum += number;

                //avg
                avg = sum / length;
            }

            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Avg = {0:F2}", avg);

        }

       


        }
    }

