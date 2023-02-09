using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    internal class Train
    {
        private int speed1;
        private int speed2;
        private int speed3;

        public int Speed1 { get => speed1; set => speed1 = value; }
        public int Speed2 { get => speed2; set => speed2 = value; }
        public int Speed3 { get => speed3; set => speed3 = value; }

        public Train (int speed1, int speed2, int speed3)
        {
            Speed1 = speed1;
            Speed2 = speed2;
            Speed3 = speed3;
        }

        public override string ToString()
        {
            return "Скорость поезда ( 1 - " + Speed1 + " Км/ч, 2 - " + Speed2 + " Км/ч, 3 - " + Speed3 + " Км/ч)";
        }
    }
}