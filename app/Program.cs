﻿using System;
using static System.Console;
using Library;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"The answer is {new Thing().Get(191, 23)}");
        }
    }
}
