using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A01_Volodymyr.Categories.Mammals;
using A01_Volodymyr.Categories.Birds;

namespace A01_Volodymyr.Misc
{
    public class CheckInput
    {
        public int TestInput(int index1, int index2, string name, string strAge, string gender, 
    string spec1, string spec2, string spec3)
        {
            int code;

            AddAnimal addAnimal = new AddAnimal();

            try
            {
                int age = int.Parse(strAge);
                if(age < 0)
                {
                    code = 104; //when age is negative
                    return code; 
                }
            }
            catch(System.FormatException)
            {
                code = 104; //when age was not given/is not a number
                return code;
            }

            if(index1 < 0)
            {
                code = 101; //when animal categoty is not selected
                return code;
            }
            else if(index2 < 0)
            {
                code = 102; //when animal object is not selected
                return code;
            }
            else if(String.IsNullOrEmpty(name))
            {
                code = 103; //when name was not recorded
                return code;
            }
            else if(String.IsNullOrEmpty(gender))
            {
                code = 105; //when gender was not stated
                return code;
            }
            else
            {
                AnimalCategory animalCategory = addAnimal.GetAnimalCategory(index1);

                switch (animalCategory)
                {
                    case AnimalCategory.Mammal:
                        try
                        {
                            int test = int.Parse(spec1);
                        }
                        catch(System.FormatException)
                        {
                            code = 106; //when the first parameter was not given as a number or was not given at all
                            return code;
                        }

                        try
                        {
                            double test = double.Parse(spec2);
                        }
                        catch (System.FormatException)
                        {
                            code = 107; //when the first parameter was not given as a number or was not given at all
                            return code;
                        }


                        MammalCategory mammalCategory = (MammalCategory)index2;

                        switch(mammalCategory)
                        {
                            case MammalCategory.Dog:
                                if (String.IsNullOrEmpty(spec3))
                                {
                                    code = 108; //when breed type was not provided
                                    return code;
                                }
                                else if(spec3.All(char.IsDigit))
                                {
                                    code = 114; //when the breed name contains digits
                                    return code;
                                }
                                break;

                            case MammalCategory.Elephant:
                                try
                                {
                                    double test = double.Parse(spec3);
                                }
                                catch (System.FormatException)
                                {
                                    code = 109; //when the trunk size was not given as a number or was not given at all
                                    return code;
                                }
                                break;
                        }
                        
                        break;

                    case AnimalCategory.Bird:

                        BirdCategory birdCategory = (BirdCategory)index2;

                        try
                        {
                            int test = int.Parse(spec1);
                        }
                        catch (System.FormatException)
                        {
                            code = 106; //when the first parameter was not given as a number or was not given at all
                            return code;
                        }

                        try
                        {
                            double test = double.Parse(spec2);
                        }
                        catch (System.FormatException)
                        {
                            code = 107; //when the first parameter was not given as a number or was not given at all
                            return code;
                        }

                        switch (birdCategory)
                        {
                            case BirdCategory.Ostrich:
                                if (String.IsNullOrEmpty(spec3))
                                {
                                    code = 112; //when leg size was not provided
                                    return code;
                                }
                                else
                                {
                                    try
                                    {
                                        int test = int.Parse(spec3);
                                    }
                                    catch(System.FormatException)
                                    {
                                        code = 115;
                                        return code;
                                    }
                                }
                                break;

                            case BirdCategory.Quail:
                                try
                                {
                                    double test = double.Parse(spec3);
                                }
                                catch (System.FormatException)
                                {
                                    code = 113; //when the total size was not given as a number or was not given at all
                                    return code;
                                }
                                break;
                        }


                        break;
                }

                code = 100;
                return code;
            }

        }


        public AnimalCategory GetAnimalCategory(int index)
        {
            AnimalCategory category = (AnimalCategory)index - 1;

            return category;
        }
    }
}
