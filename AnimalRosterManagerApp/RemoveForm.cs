using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using static AnimalRosterManagerApp.MainMenu;
using static AnimalRosterManagerApp.GroupSelectionMenu;


namespace AnimalRosterManagerApp
{
    public partial class RemoveForm : Form
    {
        private readonly GroupSelection selectedGroup;
        private ArrayList theAnimals;

        public RemoveForm(GroupSelection group)
        {
            InitializeComponent();
            selectedGroup = group;
        }

        private void RemoveForm_Load(object sender, EventArgs e)
        {
            StreamReader inStream = new StreamReader(AnimalDataFileLocation(selectedGroup));

            switch (selectedGroup)
            {
                case GroupSelection.Birds:
                    lblTitle.Text = "Birds";
                    break;
                case GroupSelection.Reptiles:
                    lblTitle.Text = "Reptiles";
                    break;
                case GroupSelection.Mammals:
                    lblTitle.Text = "Mammals";
                    break;
                default:
                    lblTitle.Text = "All Other Animals";
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
            if (lstBxAnimalNames.SelectedIndex == -1)
            {
                txtBxAnimalInfo.Text = "";
            }
            else
            {
                txtBxAnimalInfo.Text = theAnimals[lstBxAnimalNames.SelectedIndex].ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstBxAnimalNames.SelectedIndex == -1)
            {
                MessageBox.Show("No animal was selected for deletion.", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                string confirmationPrompt = "Are you sure you want to delete the selected animal from the system?\n\n" +
                                            "THIS ACTION IS IRREVERSIBLE!!!";

                DialogResult confirmation = MessageBox.Show(confirmationPrompt, "Important!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (confirmation == DialogResult.Yes)
                {
                    int indexHolder = lstBxAnimalNames.SelectedIndex;
                    lstBxAnimalNames.Items.RemoveAt(indexHolder);
                    theAnimals.RemoveAt(indexHolder);
                    lstBxAnimalNames.SelectedIndex = -1;
                    txtBxAnimalInfo.Text = "";

                    StreamWriter outStream = new StreamWriter(AnimalDataFileLocation(selectedGroup), false);

                    switch (selectedGroup)
                    {
                        case GroupSelection.Birds:
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

        private void BtnGroupSelection_Click(object sender, EventArgs e)
        {
            Hide();
            new GroupSelectionMenu(SystemOption.Remove).ShowDialog();
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
            string instructions = "Select the name of the animal you want to remove from the list to the left.  "
                                + "Then, click the \"Delete Selected\" button to remove the animal from the roster.";

            MessageBox.Show(instructions, "Remove Animal Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Animal Roster Management System\n"
                         + "Created by Terence Lee for ITDEV-185 Spring 2020";

            MessageBox.Show(about, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
