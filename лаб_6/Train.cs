﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Train : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Train is moving.");
        }
    }
}