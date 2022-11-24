using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Volodymyr.Categories.Mammals
{
    //establishing an inheritance

    public class Elephant:Mammal
    {
        double trunkLength;

        //a constructor for the Elephant class that takes the values from the base class (Mammal)

        public Elephant(int numOfTeeth, double tailLength) : base(numOfTeeth, tailLength)
        {
            trunkLength = 0;
        }

        //Trunk Length property that is unique to the Elephant class

        public double TrunkLength
        {
            get { return trunkLength; }
            set { trunkLength = value; }
        }

        //overriding the default ToString()

        public override string ToString()
        {
            string strOut = base.ToString();
            if(trunkLength > 0)
            {
                strOut += String.Format("Trunk length (cm): {0}.", trunkLength.ToString());
            }
            else
            {
                strOut += "Trunk length (cm): unknown.";
            }

            return strOut;
        }
    }
}
