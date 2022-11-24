using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A01_Volodymyr.Categories.Mammals;
using A01_Volodymyr.Categories.Birds;

namespace A01_Volodymyr
{
    public class AddAnimal
    {

        /// <summary>
        /// <para>This static metod is the one that recieves the values and uses them to create a new object of the <see cref="A01_Volodymyr.Animal"/> type </para>
        /// <para>You can see that spec1 ("№ of teeth" for Mammals and "№ of feathers" for Birds) and spec2 ("Tail Length" for Mammals and "Egg Diameter" for Birds) 
        /// are saved as strings. My reasoning was as follows</para>
        /// <para>In the current state of the program, both of those specifications coincidentally have the same type 
        /// (int for "№ of teeth" for Mammals and "№ of feathers" and double for "Tail Length" and "Egg Diameter")
        /// However, what if a new category was introduced which would have a specification of a different type (for ex. <summary cref=float, char, bool> </summary>etc)
        /// If I write the program for int and double only, integrating the new category would be relatively difficult
        /// //Therefore, I needed to have a type that could be converted into anything
        /// //I learned that C# doesn't support "var" type in methods
        /// //Thus, I decided to use "string" type as the closest universal variable type
        /// //Now, if a new category is added with a variable type "bool", all we have to do is to write a convertion metod in the class for the category
        /// //and make sure that the category recieves proper values in the <see cref="A01_Volodymyr.Misc.CheckInput"/> class
        /// instead of re-writing a big chunk of the program</para>
        /// 
        /// <para>That being said, I am not sure this is the best way to do is. Thinking back, method overloading might have been a better approach. 
        /// This, however, was the quickest way I could do it, given my limited C# experience</para>
        /// </summary>

        public static Animal AddNewAnimal(int index1, int index2, string name, string strAge, string gender, bool isEndangered,
            string spec1, string spec2, string spec3) 
        {
            //static methods require a creation of the AddAnimal class
            //I need to use this class to use GetAnimalCategory() method
            AddAnimal addAnimal = new AddAnimal();

            //creating a new animal object
            Animal newAnimal = null;

            //index1 is used to determine the category (Mammal or Bird)
            //0 is Mammal and 1 is Bird
            //If more categories were to be included, we could easily modify the program by simply adding more switch statements
            AnimalCategory animalCategory = addAnimal.GetAnimalCategory(index1);

            switch(animalCategory)
            {
                case AnimalCategory.Mammal:
                    //determining which specie (0 - Dog, 1 - Elephant) is to be created
                    MammalCategory mammalCategory = (MammalCategory)index2;
                    //sending all the info to create a new animal specie of the mammal category
                    newAnimal = AddMammal.CreateMammal(mammalCategory, spec1, spec2, spec3);

                    break;

                case AnimalCategory.Bird:
                    //determining which specie (0 - Ostrich, 1 - Quail) is to be created
                    BirdCategory birdCategory = (BirdCategory)index2;
                    //sending all the info to create a new animal specie of the bird category
                    newAnimal = AddBird.CreateBird(birdCategory, spec1, spec2, spec3);

                    break;
            }

            int age = int.Parse(strAge);
            //asigning last details to the newly created animal
            newAnimal.Name = name;
            newAnimal.Age = age;
            newAnimal.Gender = gender;
            newAnimal.AnimalCategory = animalCategory;
            newAnimal.Endangered = isEndangered;

            return newAnimal;
        }

        /// <summary>
        /// <para>Gets a <see cref="A01_Volodymyr.AnimalCategory"/> based on the index </para>
        /// </summary>
        public AnimalCategory GetAnimalCategory(int index)
        {
            AnimalCategory category = (AnimalCategory)index;

            return category;
        }
    }
}
