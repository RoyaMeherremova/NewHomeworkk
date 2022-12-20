using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work.Models
{
    internal class Shark:Animal
    {
        public int Teeth { get; set; }
        public override void Sound()
        {
            Console.WriteLine("Shark sound");
        }
        public override void Eating()
        {

            Console.WriteLine("Shark eating");
        }
    }
}
