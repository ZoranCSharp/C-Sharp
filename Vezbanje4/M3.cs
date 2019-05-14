using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje4
{
    //M3 is a BMW
   sealed class M3:BMW
    {
        public M3(string model, int hp, string color):base(model, hp, color)
        {
            this.Model = model;
        }

        /*
        public override void Repair()
        {
            Console.WriteLine("M3 Was repaired!");
        }
        */
    }
}
