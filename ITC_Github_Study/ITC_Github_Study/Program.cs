﻿using System;

namespace ITC_Github_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            n = numInput();
            m = numInput();

            n += m;
            Console.WriteLine("足し算の答えは{0}です", 0);
            Console.Read();
        }

        static int numInput()
        {
            int num;
            Console.Write("数字を入力してください ");
            int.TryParse(Console.ReadLine(), out num);
            return num;
        }
    }
}
