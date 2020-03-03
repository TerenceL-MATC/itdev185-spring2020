using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using static AnimalRosterManagerApp.MainMenu;
using static AnimalRosterManagerApp.GroupSelectionMenu;

namespace AnimalRosterManagerApp
{
    public partial class EditForm : Form
    {
        private readonly GroupSelection selectedGroup;
        private ArrayList theAnimals;

        public EditForm(GroupSelection group)
        {
            InitializeComponent();
            selectedGroup = group;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            StreamReader inStream = new StreamReader(AnimalDataFileLocation(selectedGroup));

            switch (selectedGroup)
            {
                case GroupSelection.Birds:
                    pnlUniqueBirdQuestion.Visible = true;
                    lblTitle.Text = "Edit a Bird\'s Info";
                    break;
                case GroupSelection.Reptiles:
                    pnlUniqueReptileQuestions.Visible = true;
                    lblTitle.Text = "Edit a Reptile\'s Info";
                    break;
                case GroupSelection.Mammals:
                    pnlUniqueMammalQuestions.Visible = true;
                    lblTitle.Text = "Edit a Mammal\'s Info";
                    break;
                default:
                    lblTitle.Text = "Edit an Animal\'s Info";
                    break;
            }

            lblTitle.Location = CenterTheLabel();

            theAnimals = new ArrayList();

            switch (selectedGroup)
            {
                case GroupSelection.Birds:
                    while (!inStream.EndOfStream)
                    {
                        Bird aBird = new Bird
                        {
                            Name = inStream.ReadLine(),
                            Age = int.Parse(inStream.ReadLine()),
                            Gender = inStream.ReadLine(),
                            ZooLocation = inStream.ReadLine(),
                            Type = inStream.ReadLine(),
                            DietType = inStream.ReadLine(),
                            HowTheAnimalMoves = inStream.ReadLine(),
                            IsTagged = Reptile.ConvertYesNoIntoBool(inStream.ReadLine())
                        };

                        inStream.ReadLine();
                        theAnimals.Add(aBird);
                    }
                    break;
                case GroupSelection.Reptiles:
                    while (!inStream.EndOfStream)
                    {
                        Reptile aReptile = new Reptile
                        {
                            Name = inStream.ReadLine(),
                            Age = int.Parse(inStream.ReadLine()),
                            Gender = inStream.ReadLine(),
                            ZooLocation = inStream.ReadLine(),
                            Type = inStream.ReadLine(),
                            DietType = inStream.ReadLine(),
                            HowTheAnimalMoves = inStream.ReadLine(),
                            HasAShell = Reptile.ConvertYesNoIntoBool(inStream.ReadLine()),
                            LivesIndoors = Reptile.ConvertYesNoIntoBool(inStream.ReadLine())
                        };

                        inStream.ReadLine();
                        theAnimals.Add(aReptile);
                    }
                    break;
                case GroupSelection.Mammals:
                    while (!inStream.EndOfStream)
                    {
                        Mammal aMammal = new Mammal
                        {
                            Name = inStream.ReadLine(),
                            Age = int.Parse(inStream.ReadLine()),
                            Gender = inStream.ReadLine(),
                            ZooLocation = inStream.ReadLine(),
                            Type = inStream.ReadLine(),
                            DietType = inStream.ReadLine(),
                            HowTheAnimalMoves = inStream.ReadLine(),
                            Weight = double.Parse(inStream.ReadLine()),
                            DailyMealCount = int.Parse(inStream.ReadLine())
                        };

                        inStream.ReadLine();
                        theAnimals.Add(aMammal);
                    }
                    break;
                case GroupSelection.Others:
                    while (!inStream.EndOfStream)
                    {
                        Animal anAnimal = new Animal
                        {
                            Name = inStream.ReadLine(),
                            Age = int.Parse(inStream.ReadLine()),
                            Gender = inStream.ReadLine(),
                            ZooLocation = inStream.ReadLine(),
                            Type = inStream.ReadLine(),
                            DietType = inStream.ReadLine(),
                            HowTheAnimalMoves = inStream.ReadLine()
                        };

                        inStream.ReadLine();
                        theAnimals.Add(anAnimal);
                    }
                    break;
            }

            theAnimals.TrimToSize();

            foreach (Animal animal in theAnimals)
            {
                lstBxAnimalNames.Items.Add(animal.Name);
            }

            inStream.Close();
        }

        private Point CenterTheLabel()
        {
            int y = (Height / 8) - (lblTitle.Height / 2);
            int x = (Width / 2) - (lblTitle.Width / 2);
            return new Point(x, y);
        }

        private void LstBxAnimalNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstBxAnimalNames.SelectedIndex == -1)
            {
                txtBxName.Text = null;
                txtBxAge.Text = null;
                cmbBxGender.SelectedItem = null;
                txtBxLocation.Text = null;
                txtBxType.Text = null;
                cmbBxDietType.SelectedItem = null;
                txtBxMovement.Text = null;

                switch (selectedGroup)
                {
                    case GroupSelection.Birds:
                        cmbBxIsTagged.SelectedItem = null;
                        break;
                    case GroupSelection.Reptiles:
                        cmbBxHasAShell.SelectedItem = null;
                        cmbBxLivesIndoors.SelectedItem = null;
                        break;
                    case GroupSelection.Mammals:
                        txtBxWeight.Text = null;
                        cmbBxDailyMeal.SelectedItem = null;
                        break;
                }
            }
            else
            {
                Animal selectedAnimal = (Animal)theAnimals[lstBxAnimalNames.SelectedIndex];
                txtBxName.Text = selectedAnimal.Name;
                txtBxAge.Text = selectedAnimal.Age.ToString();
                cmbBxGender.SelectedItem = selectedAnimal.Gender;
                txtBxLocation.Text = selectedAnimal.ZooLocation;
                txtBxType.Text = selectedAnimal.Type;
                cmbBxDietType.SelectedItem = selectedAnimal.DietType;
                txtBxMovement.Text = selectedAnimal.HowTheAnimalMoves;

                switch (selectedGroup)
                {
                    case GroupSelection.Birds:
                        Bird selectedBird = (Bird)selectedAnimal;
                        cmbBxIsTagged.SelectedItem = Reptile.ConvertBoolIntoYesNo(selectedBird.IsTagged);
                        break;
                    case GroupSelection.Reptiles:
                        Reptile selectedReptile = (Reptile)selectedAnimal;
                        cmbBxHasAShell.SelectedItem = Reptile.ConvertBoolIntoYesNo(selectedReptile.HasAShell);
                        cmbBxLivesIndoors.SelectedItem = Reptile.ConvertBoolIntoYesNo(selectedReptile.LivesIndoors);
                        break;
                    case GroupSelection.Mammals:
                        Mammal selectedMammal = (Mammal)selectedAnimal;
                        txtBxWeight.Text = selectedMammal.Weight.ToString();
                        cmbBxDailyMeal.SelectedItem = selectedMammal.DailyMealCount.ToString();
                        break;
                }
            }
        }

        private void BtnSaveEdits_Click(object sender, EventArgs e)
        {
            if (ValidatedUserEnteredData())
            {
                string confirmationPrompt = "Are you sure you want to save the changes you made to the selected animal from the system?\n\n";

                DialogResult confirmation = MessageBox.Show(confirmationPrompt, "Important!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    StreamWriter outStream = new StreamWriter(AnimalDataFileLocation(selectedGroup), false);

                    switch (selectedGroup)
                    {
                        case GroupSelection.Birds:
                            Bird editedBird = new Bird
                            {
                                Name = txtBxName.Text,
                                Age = int.Parse(txtBxAge.Text),
                                Gender = cmbBxGender.SelectedItem.ToString(),
                                ZooLocation = txtBxLocation.Text,
                                Type = txtBxType.Text,
                                DietType = cmbBxDietType.SelectedItem.ToString(),
                                HowTheAnimalMoves = txtBxMovement.Text,
                                IsTagged = Reptile.ConvertYesNoIntoBool(cmbBxIsTagged.SelectedItem.ToString())
                            };

                            theAnimals[lstBxAnimalNames.SelectedIndex] = editedBird;

                            foreach (Bird aBird in theAnimals)
                            {
                                outStream.WriteLine(aBird.Name);
                                outStream.WriteLine(aBird.Age);
                                outStream.WriteLine(aBird.Gender);
                                outStream.WriteLine(aBird.HowTheAnimalMoves);
                                outStream.WriteLine(aBird.ZooLocation);
                                outStream.WriteLine(aBird.Type);
                                outStream.WriteLine(aBird.DietType);
                                outStream.WriteLine(Reptile.ConvertBoolIntoYesNo(aBird.IsTagged));
                                outStream.WriteLine();
                            }
                            break;
                        case GroupSelection.Reptiles:
                            Reptile editedReptile = new Reptile
                            {
                                Name = txtBxName.Text,
                                Age = int.Parse(txtBxAge.Text),
                                Gender = cmbBxGender.SelectedItem.ToString(),
                                ZooLocation = txtBxLocation.Text,
                                Type = txtBxType.Text,
                                DietType = cmbBxDietType.SelectedItem.ToString(),
                                HowTheAnimalMoves = txtBxMovement.Text,
                                HasAShell = Reptile.ConvertYesNoIntoBool(cmbBxHasAShell.SelectedItem.ToString()),
                                LivesIndoors = Reptile.ConvertYesNoIntoBool(cmbBxLivesIndoors.SelectedItem.ToString())
                            };

                            theAnimals[lstBxAnimalNames.SelectedIndex] = editedReptile;
 
                            foreach (Reptile aReptile in theAnimals)
                            {
                                outStream.WriteLine(aReptile.Name);
                                outStream.WriteLine(aReptile.Age);
                                outStream.WriteLine(aReptile.Gender);
                                outStream.WriteLine(aReptile.HowTheAnimalMoves);
                                outStream.WriteLine(aReptile.ZooLocation);
                                outStream.WriteLine(aReptile.Type);
                                outStream.WriteLine(aReptile.DietType);
                                outStream.WriteLine(Reptile.ConvertBoolIntoYesNo(aReptile.HasAShell));
                                outStream.WriteLine(Reptile.ConvertBoolIntoYesNo(aReptile.LivesIndoors));
                                outStream.WriteLine();
                            }
                            break;
                        case GroupSelection.Mammals:
                            Mammal editedMammal = new Mammal
                            {
                                Name = txtBxName.Text,
                                Age = int.Parse(txtBxAge.Text),
                                Gender = cmbBxGender.SelectedItem.ToString(),
                                ZooLocation = txtBxLocation.Text,
                                Type = txtBxType.Text,
                                DietType = cmbBxDietType.SelectedItem.ToString(),
                                HowTheAnimalMoves = txtBxMovement.Text,
                                Weight = double.Parse(txtBxWeight.Text),
                                DailyMealCount = int.Parse(cmbBxDailyMeal.Text)
                            };

                            theAnimals[lstBxAnimalNames.SelectedIndex] = editedMammal;

                            foreach (Mammal aMammal in theAnimals)
                            {
                                outStream.WriteLine(aMammal.Name);
                                outStream.WriteLine(aMammal.Age);
                                outStream.WriteLine(aMammal.Gender);
                                outStream.WriteLine(aMammal.HowTheAnimalMoves);
                                outStream.WriteLine(aMammal.ZooLocation);
                                outStream.WriteLine(aMammal.Type);
                                outStream.WriteLine(aMammal.DietType);
                                outStream.WriteLine(aMammal.Weight);
                                outStream.WriteLine(aMammal.DailyMealCount);
                                outStream.WriteLine();
                            }
                            break;
                        default:
                            Animal editedAnimal = new Animal
                            {
                                Name = txtBxName.Text,
                                Age = int.Parse(txtBxAge.Text),
                                Gender = cmbBxGender.SelectedItem.ToString(),
                                ZooLocation = txtBxLocation.Text,
                                Type = txtBxType.Text,
                                DietType = cmbBxDietType.SelectedItem.ToString(),
                                HowTheAnimalMoves = txtBxMovement.Text
                            };

                            theAnimals[lstBxAnimalNames.SelectedIndex] = editedAnimal;

                            foreach (Animal anAnimal in theAnimals)
                            {
                                outStream.WriteLine(anAnimal.Name);
                                outStream.WriteLine(anAnimal.Age);
                                outStream.WriteLine(anAnimal.Gender);
                                outStream.WriteLine(anAnimal.HowTheAnimalMoves);
                                outStream.WriteLine(anAnimal.ZooLocation);
                                outStream.WriteLine(anAnimal.Type);
                                outStream.WriteLine(anAnimal.DietType);
                                outStream.WriteLine();
                            }
                            break;
                    }

                    outStream.Close();
                }
            }
        }

        private bool ValidatedUserEnteredData()
        {
            Control controlToFocusOn = new Control();
            string validationFailureMessage = null;

            switch (selectedGroup)
            {
                case GroupSelection.Birds:
                    if (cmbBxIsTagged.SelectedItem == null)
                    {
                        validationFailureMessage = "Please select if the bird is tagged.";
                        controlToFocusOn = cmbBxIsTagged;
                    }
                    break;
                case GroupSelection.Reptiles:
                    if (cmbBxLivesIndoors.SelectedItem == null)
                    {
                        validationFailureMessage = "Please select if the reptile lives indoors.";
                        controlToFocusOn = cmbBxLivesIndoors;
                    }
                    if (cmbBxHasAShell.SelectedItem == null)
                    {
                        validationFailureMessage = "Please select if the reptile has a shell.\n" + validationFailureMessage;
                        controlToFocusOn = cmbBxHasAShell;
                    }
                    break;
                case GroupSelection.Mammals:
                    if (cmbBxDailyMeal.SelectedItem == null)
                    {
                        validationFailureMessage = "Please select the number of meals that the animal eats per day.\n";
                        controlToFocusOn = cmbBxDailyMeal;
                    }
                    if (string.IsNullOrWhiteSpace(txtBxWeight.Text) || !double.TryParse(txtBxWeight.Text, out double weight) || weight <= 0.0)
                    {
                        validationFailureMessage = "Please enter a positive value for weight.\n" + validationFailureMessage;
                        controlToFocusOn = txtBxWeight;
                    }
                    break;
            }

            if (string.IsNullOrWhiteSpace(txtBxMovement.Text))
            {
                validationFailureMessage = "Please enter how the animal moves.\n" + validationFailureMessage;
                controlToFocusOn = txtBxMovement;
            }
            if (cmbBxDietType.SelectedItem == null)
            {
                validationFailureMessage = "Please select the type of the animal\'s diet.\n" + validationFailureMessage;
                controlToFocusOn = cmbBxDietType;
            }
            if (string.IsNullOrWhiteSpace(txtBxType.Text))
            {
                validationFailureMessage = "Please enter a type for the animal.\n" + validationFailureMessage;
                controlToFocusOn = txtBxType;
            }
            if (string.IsNullOrWhiteSpace(txtBxLocation.Text))
            {
                validationFailureMessage = "Please enter a name for the location of the animal.\n" + validationFailureMessage;
                controlToFocusOn = txtBxLocation;
            }
            if (cmbBxGender.SelectedItem == null)
            {
                validationFailureMessage = "Please select the gender of the animal.\n" + validationFailureMessage;
                controlToFocusOn = cmbBxGender;
            }
            if (string.IsNullOrWhiteSpace(txtBxAge.Text) || !int.TryParse(txtBxAge.Text, out int age) || age <= 0)
            {
                validationFailureMessage = "Please enter a value, 1 or greater, for age.\n" + validationFailureMessage;
                controlToFocusOn = txtBxAge;
            }
            if (string.IsNullOrWhiteSpace(txtBxName.Text))
            {
                validationFailureMessage = "Please enter a name for the animal.\n" + validationFailureMessage;
                controlToFocusOn = txtBxName;
            }

            if (validationFailureMessage == null)
            {
                return true;
            }

            validationFailureMessage = "Please do the following:\n\n" + validationFailureMessage;
            MessageBox.Show(validationFailureMessage, "Data Validation Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            controlToFocusOn.Focus();
            return false;
        }

        private void BtnGroupSelection_Click(object sender, EventArgs e)
        {
            Hide();
            new GroupSelectionMenu(SystemOption.Edit).ShowDialog();
            Close();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            new MainMenu().ShowDialog();
            Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userAnswer;
            userAnswer = MessageBox.Show("Are you sure you want to close the program?", "Leaving?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userAnswer == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void InstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string instructions = "Select the animal\'s name you want to edit from the list on the left.  "
                                + "Then, changed the value for any of the fields to the right.  "
                                + "Once you're finished, click on the \"Save Changes\" button to save your changes.";

            MessageBox.Show(instructions, "Edit Animal Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Animal Roster Management System\n"
                         + "Created by Terence Lee for ITDEV-185 Spring 2020";

            MessageBox.Show(about, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
