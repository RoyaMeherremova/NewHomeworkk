﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work.Models
{
    internal class Bird:Animal
    {
        public string Type { get; set; }
        public override void Sound()
        {
            Console.WriteLine("Bird sound");
        }
        public override void Eating()
        {
            Console.WriteLine("Bird eating");
        }

    }
}
