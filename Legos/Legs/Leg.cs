using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legos
{
    public class Leg
    {
        public string Color { get; set; }
        public int Movement { get; set; }



        public Leg(string color)
        {
            Color = color;

        }
    }
}
