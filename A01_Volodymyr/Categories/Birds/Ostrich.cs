using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Volodymyr.Categories.Birds
{
    //establishing an inheritance
    public class Ostrich:Bird
    {
        double legLength;

        //a constructor for the class that takes the values from the base class (Bird)
        public Ostrich(int numOfFeathers, double eggDiameter) : base(numOfFeathers, eggDiameter)
        {
            legLength = 0;
        }
        //getter and setter for the leg length
        public double LegLength
        {
            get { return legLength; }
            set { legLength = value; }
        }
        //overrides the default ToString()
        public override string ToString()
        {
            string strOut = base.ToString();
            strOut += String.Format("Leg length {0}.", LegLength.ToString());

            return strOut;
        }
    }
}
