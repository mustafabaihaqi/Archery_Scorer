using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryScorer
{
    public class Bow
    {
        string brand;
        string name;
        string type;
        double drawWeight;
        double drawLength;
        double fps;

        public string Brand { get => brand; }
        public string Name { get => name; }
        public string Type { get => type; }
        public double DrawWeight { get => drawWeight; set => drawWeight = value; }
        public double Drawlength { get => drawLength; set => drawLength = value; }

        public Bow(string brand, string name, string type, double drawWeight, double drawLength)
        {
            this.brand = brand;
            this.name = name;
            this.type = type;
            this.drawWeight = drawWeight;
            this.drawLength = drawLength;
        }

        public Bow ()
        {
        }

        public virtual void showBowInformation()
        {
            Console.WriteLine("Busur anda adalah {2} {0} {1} dengan {3} lbs draw weight dan {4} inch draw length", brand, name, type, drawWeight, drawLength);
        }

        public virtual double SpeedRating(double drawLength, double drawWeight)
        {
            double speed = 0;
            speed = drawLength * drawWeight * 0.18;
            return speed;
        }

        public virtual double SpeedRating()
        {
            double speed = 0;
            speed = drawLength * drawWeight * 0.18;
            return speed;
        }
    }
}
