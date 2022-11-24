using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Volodymyr.Categories.Birds
{
    //establishing an inheritance
    public class Quail:Bird
    {
        int totalSize;

        //a constructor for the class that takes the values from the base class (Bird)
        public Quail (int numOfFeathers, double eggDiameter): base (numOfFeathers, eggDiameter)
        {
            totalSize = 0;
        }
        //getter and setter for the total size
        public int TotalSize
        {
            get { return totalSize; }
            set { totalSize = value; }
        }
        //overriding the default ToString()
        public override string ToString()
        {
            string strOut = base.ToString();
            strOut += String.Format("Total length {0}.", TotalSize.ToString());

            return strOut;
        }

    }
}
