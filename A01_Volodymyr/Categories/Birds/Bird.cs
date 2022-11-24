using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Volodymyr.Categories
{
    //establishing an inheritance
    public class Bird:Animal
    {
        int numOfFeathers;
        double eggDiameter;

        //constructor for the bird class that takes two unique parameter to the birds: number of feathers and egg diameter
        public Bird(int numOfFeathers, double eggDiameter)
        {
            this.numOfFeathers = numOfFeathers;
            this.eggDiameter = eggDiameter;
        }
        //getters and setters for the aforementioned properties
        public int NumOfFeathers
        {
            get { return numOfFeathers; }
            set { numOfFeathers = value; }
        }

        public double EggDiameter
        {
            get { return eggDiameter; }
            set { eggDiameter = value; }
        }
        //overriding a default ToString()
        public override string ToString()
        {
            string strOut = base.ToString();
            strOut += String.Format("{0,-15} {1,6}\n{2, -10} {3, 6}\n", "Number of Feathers:", NumOfFeathers, "Egg Diameter", EggDiameter);

            return strOut;
        }
    }
}
