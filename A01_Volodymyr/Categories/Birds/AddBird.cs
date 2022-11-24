using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Volodymyr.Categories.Birds
{
    public class AddBird
    {
        /// <summary>
        /// <para>This class is for the final stage of the animal creation of the mammal category</para>
        /// <para>It late binds a <see cref="A01_Volodymyr.Categories.Birds.Ostrich"/> or <see cref="A01_Volodymyr.Categories.Birds.Quail"/> to the animal</para>
        /// </summary>


        public static Bird CreateBird(BirdCategory category, string spec1, string spec2, string spec3)
        {
            //creating a new bird
            Bird bird = null;
            //converting the strings into an int and a double
            int numOfFeathers = int.Parse(spec1);
            double eggDiameter = double.Parse(spec2);

            //this switch determines if we will be creating an Ostrich or a Quail
            switch (category)
            {
                case BirdCategory.Ostrich:
                    //late binding an Ostrich to the animal
                    bird = new Ostrich(numOfFeathers, eggDiameter);
                    //recording the leg length for the Ostrich
                    ((Ostrich)bird).LegLength = int.Parse(spec3);
                    break;

                case BirdCategory.Quail:
                    //late binding a Quail to the animal
                    bird = new Quail(numOfFeathers, eggDiameter);
                    //recording the total size of the Quail
                    ((Quail)bird).TotalSize = int.Parse(spec3);
                    break;
            }

            return bird;
        }
    }
}
