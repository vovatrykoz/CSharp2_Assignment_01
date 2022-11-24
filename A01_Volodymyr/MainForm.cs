using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A01_Volodymyr.Categories;
using A01_Volodymyr.Categories.Mammals;
using A01_Volodymyr.Categories.Birds;
using A01_Volodymyr.Misc;

namespace A01_Volodymyr
{
    public partial class MainForm : Form
    {
        AnimalManager animalManager = new AnimalManager();
        AddAnimal addAnimal = new AddAnimal();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        //setting the datasources for listboxes from corresponding Enums
        private void InitializeGUI()
        {
            lstGender.DataSource = Enum.GetValues(typeof(AnimalGender));
            lstCategory.DataSource = Enum.GetValues(typeof(AnimalCategory));
            btnImage.Enabled = false;
        }

        /// <summary>The method responsible for reacting to the "Add" button
        /// <para>There were a few things to keep in mind</para>
        /// <para>First, I needed to make sure an animal could be created in two cases: when the animals are listed separatly and when they are all on the same page
        /// </summary>
        /// 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index1 = -1; //index1 determines which category (Mammal or Bird) is selected. Mammal corresponds to value "0" and Bird to value "1"
            int index2 = -1; //index2 determines which objects (species) were selected. Dog and Ostrich correspond to value "0" and Elephant and Quail to "1"

            //if "List all animals" is unchecked, we just get the index from the listbox directly. since only 0 and 1 are possible
            //Given there are only two categories of course
            if (!chkAnimals.Checked) 
            {
                index1 = lstCategory.SelectedIndex;
            }
            else
            {
                //however, if we are listing all animals simultaniously, the values will go beyond 1 (up to 3 in my example)
                //therefore, we can't rely on listbox to give us the values
                //instead, we have to assign them directly using the pre-established logic of the program
                //We remember that Mammal corresponds to value "0" and Bird to value "1"

                switch (lstObjects.Text)
                {
                    case "Dog":
                        index1 = 1;
                        break;

                    case "Elephant":
                        index1 = 1;
                        break;

                    case "Ostrich":
                        index1 = 0;
                        break;

                    case "Quail":
                        index1 = 0;
                        break;
                }
            }
            //similar thing here: the the combobox is unchecked, we get the values directly
            if (!chkAnimals.Checked)
            {
                index2 = lstObjects.SelectedIndex;
            }
            else
            {
                //Dog and Ostrich correspond to value "0" and Elephant and Quail to "1"
                switch (lstObjects.Text)
                {
                    case "Dog":
                        index2 = 0;
                        break;

                    case "Elephant":
                        index2 = 1;
                        break;

                    case "Ostrich":
                        index2 = 0;
                        break;

                    case "Quail":
                        index2 = 1;
                        break;
                }

                /// <summary>
                /// <para>The program will not get confused as four combinations are possible for each specie: 0-0, 0-1, 1-0, 1-1</para>
                /// <para>All of those are taken into account</para>
                /// <para>It was neccessary to do this because I wanted to create objects in a separate class and not in the MainForm</para>>
                /// <para>If you want to see more details see <see cref="A01_Volodymyr.AddAnimal"/></para>>
                /// </summary>
            }

            //creating a new animal

            Animal newAnimal;

            //reading the user input
            string strName = txtName.Text.ToString();
            string age = txtAge.Text.ToString();
            string strGender = lstGender.SelectedItem.ToString();
            string spec1 = txtSpec1.Text;
            string spec2 = txtSpec2.Text;
            string spec3 = txtSpec3.Text;

            //check if the age has been provided
            if(String.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Please, put the age in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //read the "Endangered" checkbox

                bool isEndangered = chkEndangered.Checked;

                //Test is a bool that collects all the user input that needs checking
                //It sends it to a separate class whose task is to check user input
                //100 is a code that tells us the input has been checked successfully
                //and no errors or missing data have been found
                if (Test(index1, index2, strName, age, strGender, isEndangered,
                        spec1, spec2, spec3) == 100)
                {
                    //sends the data to the class responsible for animal creation and assigning the resulting animal to "newAnimal"
                    newAnimal = AddAnimal.AddNewAnimal(index1, index2, strName, age, strGender, isEndangered,
                        spec1, spec2, spec3);

                    //add a new animal to the list
                    animalManager.Add(newAnimal);
                    //final step - assigning an ID
                    newAnimal.ID = animalManager.Count;
                    //update the interface
                    UpdateGUI();
                }
            }

        }


        /// <summary>
        /// <para>As mentioned above, this method will collect the user input and will send it to the <see cref="A01_Volodymyr.Misc.CheckInput"/> class 
        /// </para>
        /// <para>The class will test the input and return a code based on the results</para>
        /// <para>Code 100 is success, the rest are errors of some kind</para>
        /// <para>If there were error codes received, the program will display a corresponding Message</para>
        /// </summary>
        //
        private int Test(int index1, int index2, string name, string age, string gender, bool isEndangered,
    string spec1, string spec2, string spec3)
        {
            //creating an instance of the CheckInput.cs
            CheckInput inputChecker = new CheckInput();

            //sending the values to the class and receiving a code
            int testCode = inputChecker.TestInput(index1, index2, name, age, gender,
                    spec1, spec2, spec3);

            //for more explanation of the codes see CheckInput.cs
            //However, you can probably guess which code corresponds to which error by reading the MessageBox messages

            if (testCode == 101)
            {
                MessageBox.Show("Please, select a category first", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testCode == 102)
            {
                MessageBox.Show("Please, select an object first", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testCode == 103)
            {
                MessageBox.Show("Please, put in a name", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testCode == 104)
            {
                MessageBox.Show("Please, put a proper age\n(age should not contain letters and must not be negative)", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testCode == 105)
            {
                MessageBox.Show("Please, select a gender)", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testCode == 106)
            {
                MessageBox.Show(string.Format("Please, check your input in the '{0}' field)", lblSpec1.Text), "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testCode == 107)
            {
                MessageBox.Show(string.Format("Please, check your input in the '{0}' field)", lblSpec2.Text), "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testCode == 108)
            {
                MessageBox.Show("Put in a breed name", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testCode == 109)
            {
                MessageBox.Show("Put in a trunk length", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testCode == 112)
            {
                MessageBox.Show("Put in a leg size", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testCode == 113)
            {
                MessageBox.Show("Put in a total size", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testCode == 114)
            {
                MessageBox.Show("Breed name should not contain numbers", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (testCode == 115)
            {
                MessageBox.Show(string.Format("Please, check your input in the '{0}' field. It should only contain digits in this particular case)", lblSpec3.Text), "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return testCode;
        }

        //Updating the interface upon a succesfull object creation
        private void UpdateGUI()
        {
            string[] strAnimalList = animalManager.ListToStringArray();

            if (strAnimalList != null)
            {
                lblOutput.Text = strAnimalList.Last();
                if(picBox != null && picBox.Image != null)
                {
                    picBox.Image = null;
                }
                btnImage.Enabled = true;
            }
        }

        //adjusting the items based on which category or object (specie) is currently selected
        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimalCategory category;
            string selectedCategory;

            //recording the selected listbox item
            selectedCategory = lstCategory.SelectedItem.ToString();
            //converting it to Enum so that we can use the switch
            Enum.TryParse(selectedCategory, out category);

            switch (category)
            {
                case AnimalCategory.Mammal:
                    lstObjects.DataSource = Enum.GetValues(typeof(MammalCategory));
                    lblSpec1.Text = "№ of teeth";
                    lblSpec2.Text = "Tail Length";
                    break;

                case AnimalCategory.Bird:
                    lstObjects.DataSource = Enum.GetValues(typeof(BirdCategory));
                    lblSpec1.Text = "№ of feathers";
                    lblSpec2.Text = "Egg Diameter";
                    break;
            }/*
            if (!chkAnimals.Checked)
            {


            }
            else
            {
                switch (lstObjects.Text)
                {
                    case "Dog":
                        lblSpec1.Text = "№ of teeth";
                        lblSpec2.Text = "Tail Length";
                        break;

                    case "Elephant":
                        lblSpec1.Text = "№ of teeth";
                        lblSpec2.Text = "Tail Length";
                        break;

                    case "Ostrich":
                        lblSpec1.Text = "№ of feathers";
                        lblSpec2.Text = "Egg Diameter";
                        break;

                    case "Quail":
                        lblSpec1.Text = "№ of feathers";
                        lblSpec2.Text = "Egg Diameter";
                        break;
                }
            }*/

        }

        //different animals have different specifications unique to the (t.ex. Dogs-Breed, Elephants-trunk length)
        //this method ensures that the GUI shows these features when a corresponding animal is chosen
        private void lstObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory;
            //again, two scenarios
            //Scenario 1 - animals are divided by Mammal category
            //This means we can get the values for the Switch statement directly from Enums
            //Then we convert it into strings (since we can't use two Enums at the same time when we want to use a switch)
            if(!chkAnimals.Checked)
            {
                selectedCategory = lstObjects.SelectedItem.ToString();

                switch (selectedCategory)
                {
                    case "Dog":
                        lblSpec3.Text = "Breed";
                        break;

                    case "Elephant":
                        lblSpec3.Text = "Trunk Length";
                        break;

                    case "Ostrich":
                        lblSpec3.Text = "Leg Length";
                        break;

                    case "Quail":
                        lblSpec3.Text = "Total Length";
                        break;
                }
            }
            //Scenario 2 - all animals are listed together
            //The switch will now use the text inside a listbox as a source of Data
            else
            {
                switch (lstObjects.Text)
                {
                    case "Dog":
                        lblSpec1.Text = "№ of teeth";
                        lblSpec2.Text = "Tail Length";
                        lblSpec3.Text = "Breed";
                        break;

                    case "Elephant":
                        lblSpec1.Text = "№ of teeth";
                        lblSpec2.Text = "Tail Length";
                        lblSpec3.Text = "Trunk Length";
                        break;

                    case "Ostrich":
                        lblSpec1.Text = "№ of feathers";
                        lblSpec2.Text = "Egg Diameter";
                        lblSpec3.Text = "Leg Length";
                        break;

                    case "Quail":
                        lblSpec1.Text = "№ of feathers";
                        lblSpec2.Text = "Egg Diameter";
                        lblSpec3.Text = "Total Length";
                        break;
                }
            }

        }

        //when we check the "List all animals" box, the Category listbox will be greyed
        private void chkAnimals_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAnimals.Checked)
            {
                //It is neccesssary to remove the Enum data source before modifying the listbox
                lstObjects.DataSource = null;
                lstCategory.Enabled = false;

                //since it is imposiible to use two Enums simultaniously for the data source, I decided to loop through all the Enums
                //and add all the elements into a listbox that way
                //Again, due to the fact that the program uses combinations of number (the aforementioned 0-0, 0-1, 1-0, 1-1)
                //rather then relying on actual text values
                //we will only have to do minor modifications in the rest of the program
                foreach (string name in Enum.GetNames(typeof(BirdCategory)))
                {
                    lstObjects.Items.Add(name);
                }
                foreach (string name in Enum.GetNames(typeof(MammalCategory)))
                {
                    lstObjects.Items.Add(name);
                }
            }
            else
            {
                //returns the GUI to the normal state
                lstObjects.Items.Clear();
                lstCategory.Enabled = true;
            }
        }
        //handles the image import
        private void btnImage_Click(object sender, EventArgs e)
        {
            //opening a dialogue
            OpenFileDialog openFile = new OpenFileDialog();
            //setting the title
            openFile.Title = "Import a cute animal picture!";
            //setting allowed formats
            openFile.Filter = "jpg image|*.jpg|bmp image|*.bmp|jped file|*.jpeg|gif file|*.gif";
            //showing the dialogue window
            openFile.ShowDialog();
            //setting the adjustment mode (picture will be stretched to fit the box)
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //loading the image
            picBox.Image = new Bitmap(openFile.FileName);
            //disposing the dialogue window, just in case
            openFile.Dispose();

        }
    }
}
