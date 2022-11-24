using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Volodymyr
{
    public class Animal
    {
        //definig some class variables
        int id;
        int age;

        string strName;
        string strGender;

        bool isEndangered;

        AnimalCategory animalCategory;
        //getters and setters for ID, Name, Age, Gender, Category and Endangerment status
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return strGender; }
            set { strGender = value; }
        }

        public AnimalCategory AnimalCategory
        {
            get { return animalCategory; }
            set { animalCategory = value; }
        }


        public bool Endangered
        {
            get { return isEndangered; }
            set { isEndangered = value; }
        }

        //I thought that representing endangerment status as "true" or "false" (which is what happens when a simple ToString() is used) was not that good
        //Instead, I wrote this class which uses the values "Yes" or "No" instead
        public string GetEndangermentToString()
        {
            string strOut;

            if(Endangered)
            {
                strOut = "Yes";
            }
            else
            {
                strOut = "No";
            }

            return strOut;
        }
        //overrides a usual ToString() set by the program
        //this allows us to format our string
        public override string ToString()
        {
            string strOut = string.Format("{0, -15} {1, 6}\n{2, 5} {3, 6}\n{4, -15} {5, 6}\n", "ID", ID, "Name:", Name, "Age:", age);

            strOut += string.Format("{0, -15} {1, 6}\n{2, -15} {3, 6}\n",
                "Gender:", Gender.ToString(), "Category:", AnimalCategory.ToString());

            return strOut;
        }
    }
}
