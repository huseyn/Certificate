﻿using Certificate.Chapter2.Examples.AttributeExample;
using Certificate.Chapter2.Examples.ClassExample;
using Certificate.Chapter2.Examples.DynamicTypeExample;
using Certificate.Chapter2.Examples.EnumExample;
using Certificate.Chapter2.Examples.ImplementingInterfaces;
using Certificate.Chapter2.Examples.ValueReferenceTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificate
{
    class Program
    {
        static void Main(string[] args)
        {
            MyExecute myExecute = new MyExecute();
            myExecute.GetMethod();
            Console.ReadLine();
        }
    }
}
