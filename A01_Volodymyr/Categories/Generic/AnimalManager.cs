using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_Volodymyr
{
    // a class which is essentially used as a "list" of all the animals we have
    public class AnimalManager
    {
        //creating a new list
        private List<Animal> animalList;
        //initiating the list
        public AnimalManager()
        {
            animalList = new List<Animal>();
        }
        //this property returns the current amount of items in the list
        public int Count
        {
            get { return animalList.Count; }
        }
        //this method adds a new animal to the list
        public void Add(Animal animal)
        {
            int count = Count;

            if(count != -1)
            {
                animalList.Add(animal);
                //animalList.Sort((x, y) => x.ID.CompareTo(y.ID));
            }
        }

        //the following two methods are for editing an entry in the list and deleting it
        //they don't do anything right now, since the task did not ask us for something like this
        //However, these are the templates I prepared, taken from one of my previous projects for C# I course
        //If we will have to work further with this project, I can easily modify them to fit the assignment
        //I actually wanted to fully implement them, however, didn't do it due to a poor time management

        public void Edit(int index, Animal animal)
        {
            animalList.RemoveAt(index);
            animalList.Insert(index, animal);
            animalList.Sort((x, y) => x.ID.CompareTo(y.ID));
        }

        public void Delete(int index)
        {
            if (index != -1)
            {
                animalList.RemoveAt(index);
            }
        }

        //method that returns the List<Animals> as a string[]
        public string[] ListToStringArray()
        {
            string[] taskArray = new string[Count];
            for (int i = 0; i < Count; i++) taskArray[i] = animalList[i].ToString();
            return taskArray;
        }
    }
}
