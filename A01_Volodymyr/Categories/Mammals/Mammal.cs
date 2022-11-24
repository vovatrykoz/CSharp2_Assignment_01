using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Volodymyr.Categories.Mammals
{
    //establishing an inheritance
    public class Mammal:Animal
    {
        int numOfTeeth;
        double tailLength;

        //constructor for the mammal class that takes two unique parameter to the mammals: number of teeth and tail length
        public Mammal(int numOfTeeth, double tailLength)
        {
            this.numOfTeeth = numOfTeeth;
            this.tailLength = tailLength;
        }

        //getter and setter for the TailLength
        public double TailLength
        {
            get { return tailLength; }
            set { tailLength = value; }
        }

        //getter and setter for the number of teeth
        public int TeethNumber
        {
            get { return numOfTeeth; }
            set { numOfTeeth = value; }
        }

        //overriding the default ToString()
        public override string ToString()
        {
            string strOut = base.ToString();
            strOut += String.Format("{0,-15} {1,6}\n{2, -10} {3, 6}\n", "Tail length (cm):", TailLength, "No.of teeth:", TeethNumber);


            return strOut;
        }
    }
}
