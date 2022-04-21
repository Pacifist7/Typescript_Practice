using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus
{
    public class Circles
    {
        public double Radius { get; set; }

        private double _Circumference { get; set; }

        public Circles(double radius)
        {
            Radius = radius;

            //Do the logic to figure out the circumference here

            _Circumference = 2 * Math.PI * radius;
        }

        public double GetCircumference()
        {
            return _Circumference;
        }
    }
}
