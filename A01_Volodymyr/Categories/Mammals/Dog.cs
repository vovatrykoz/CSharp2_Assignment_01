using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Volodymyr.Categories.Mammals
{
    //establishing an inheritance
    public class Dog:Mammal
    {
        public string strBreed;

        //a constructor for the Dog class that takes the values from the base class (Mammal)

        public Dog(int numOfTeeth, double tailLength) : base(numOfTeeth, tailLength)
        {
            strBreed = "unknown";
        }

        //getter and setter for the breed property
        public string Breed
        {
            get { return strBreed; }
            set { strBreed = value; }
        }

        //overriding the default ToString()
        public override string ToString()
        {
            string strOut = base.ToString();
            strOut += String.Format("Breed {0}.", strBreed);

            return strOut;
        }

    }
}
