using System;
using System.Drawing;
using System.Windows.Forms;
using static AnimalRosterManagerApp.GroupSelectionMenu;
using static AnimalRosterManagerApp.MainMenu;
using System.Collections;
using System.IO;

namespace AnimalRosterManagerApp
{
    public partial class ViewForm : Form
    {
        private readonly GroupSelection selectedGroup;
        private ArrayList theAnimals;

        public ViewForm(GroupSelection group)
        {
            InitializeComponent();

            selectedGroup = group;
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            StreamReader inStream = new StreamReader(AnimalDataFileLocation(selectedGroup));

            switch(selectedGroup)
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
            txtBxAnimalInfo.Text = theAnimals[lstBxAnimalNames.SelectedIndex].ToString();
        }

        private void BtnGroupSelection_Click(object sender, EventArgs e)
        {
            Hide();
            GroupSelectionMenu groupSelectionMenu = new GroupSelectionMenu(SystemOption.View);
            groupSelectionMenu.ShowDialog();
            Close();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
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
            string instructions = "Select an animal\'s name from the list on the left.  "
                                + "Once you make a selection, their info will be displayed in the textbox to the right.";

            MessageBox.Show(instructions, "View Animal Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Animal Roster Management System\n"
                         + "Created by Terence Lee for ITDEV-185 Spring 2020";

            MessageBox.Show(about, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
