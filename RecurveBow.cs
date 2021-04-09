using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryScorer
{
    class RecurveBow : Bow
    { 
        public RecurveBow()
        {
        }

        public RecurveBow(string brand, string name, string type, double drawWeight, double drawLength)
        {
        }

        public override void showBowInformation()
        {
            Console.WriteLine("Busur anda adalah {2} {0} {1} dengan {3} lbs draw weight dan {4} inch draw length", Brand, Name, Type, DrawWeight, Drawlength);
        }

        public override double SpeedRating(double drawLength, double drawWeight)
        {
            double speed = 0;
            speed = drawLength * drawWeight * 0.16;
            return speed;
        }
    }

    
}
