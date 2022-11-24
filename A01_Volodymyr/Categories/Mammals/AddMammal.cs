using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Volodymyr.Categories.Mammals
{

    public class AddMammal
    {
        /// <summary>
        /// <para>This class is for the final stage of the animal creation of the mammal category</para>
        /// <para>It late binds a <see cref="A01_Volodymyr.Categories.Mammals.Dog"/> or <see cref="A01_Volodymyr.Categories.Mammals.Elephant"/> to the animal</para>
        /// </summary>

        public static Mammal CreateMammal(MammalCategory category, string spec1, string spec2, string specification3)
        {
            //creating a new mammal
            Mammal mammal = null;
            //converting the strings into an int and a double
            int numOfTeeth = int.Parse(spec1);
            double tailLength = double.Parse(spec2);
            //this switch determines if we will be creating a Dog or an Elephant
            switch (category)
            {
                case MammalCategory.Dog:
                    //late binding a Dog to the animal
                    mammal = new Dog(numOfTeeth, tailLength);
                    //assigning a breed to the dog
                    ((Dog)mammal).Breed = specification3;
                    break;

                case MammalCategory.Elephant:
                    //late binding an Elephant to the animal
                    mammal = new Elephant(numOfTeeth, tailLength);
                    //assigning a trunkLength to the elephant
                    //we have to convert it, since we carried it here as string
                    //again, it was neccesarry so that I could get a Breed as a string and trunk length as an int
                    ((Elephant)mammal).TrunkLength = int.Parse(specification3);
                    break;
            }

            return mammal;
        }

    }
}
