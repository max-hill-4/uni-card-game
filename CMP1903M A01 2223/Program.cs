﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MaxH's program.
namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack Obj1 = new Pack();
            Obj1.shuffleCardPack(1);
            Obj1.deal();
        }
    }
}
