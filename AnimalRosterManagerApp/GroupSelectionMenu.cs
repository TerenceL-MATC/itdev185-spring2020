using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using static AnimalRosterManagerApp.MainMenu;

namespace AnimalRosterManagerApp
{
    public partial class GroupSelectionMenu : Form
    {
        private readonly SystemOption fileModifierOption;
        private GroupSelection selectedGroup;

        public enum GroupSelection
        {
            Birds,
            Reptiles,
            Mammals,
            Others
        }

        public GroupSelectionMenu(SystemOption userChoice)
        {
            InitializeComponent();

            fileModifierOption = userChoice;
        }

        private void GroupSelectedClickHandler()
        {
            if(fileModifierOption != SystemOption.Add && CheckForEmptyFile())
            {
                string messageForUser,
                       groupName;

                switch(selectedGroup)
                {
                    case GroupSelection.Birds:
                        groupName = "birds";
                        break;
                    case GroupSelection.Reptiles:
                        groupName = "reptiles";
                        break;
                    case GroupSelection.Mammals:
                        groupName = "mammals";
                        break;
                    default:
                        groupName = "";
                        break;
                }

                if (selectedGroup == GroupSelection.Others)
                {
                    messageForUser = "There aren\'t any animals in this category in the system.";
                }
                else
                {
                    messageForUser = "There aren\'t any " + groupName + " in the system";
                }

                MessageBox.Show(messageForUser, "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Hide();

                switch (fileModifierOption)
                {
                    case SystemOption.View:
                        new ViewForm(selectedGroup).ShowDialog(); ;
                        break;
                    case SystemOption.Add:
                        new AddForm(selectedGroup).ShowDialog(); ;
                        break;
                    case SystemOption.Remove:
                        new RemoveForm(selectedGroup).ShowDialog(); ;
                        break;
                    case SystemOption.Edit:
                        new EditForm(selectedGroup).ShowDialog(); ;
                        break;
                }

                Close();
            }
        }

        private bool CheckForEmptyFile()
        {
            int linesOfDataPerAnimal = 9,
                actualLinesOfData = 0;
            

            if(selectedGroup == GroupSelection.Birds)
            {
                linesOfDataPerAnimal = 8;
            }
            else if(selectedGroup == GroupSelection.Others)
            {
                linesOfDataPerAnimal = 7;
            }

            using(StreamReader inStream = new StreamReader(AnimalDataFileLocation(selectedGroup)))
            {
                while(actualLinesOfData != linesOfDataPerAnimal && inStream.ReadLine() != null)
                {
                    actualLinesOfData++;
                }
            }

            return actualLinesOfData != linesOfDataPerAnimal;
        }

        private Point CenterTheLabel()
        {
            int y = (Height / 8) - (lblSystemOption.Height / 2);
            int x = (Width / 2) - (lblSystemOption.Width / 2);
            return new Point(x, y);
        }

        private void BtnBirds_Click(object sender, EventArgs e)
        {
            selectedGroup = GroupSelection.Birds;
            GroupSelectedClickHandler();
        }

        private void BtnReptiles_Click(object sender, EventArgs e)
        {
            selectedGroup = GroupSelection.Reptiles;
            GroupSelectedClickHandler();
        }

        private void BtnMammals_Click(object sender, EventArgs e)
        {
            selectedGroup = GroupSelection.Mammals;
            GroupSelectedClickHandler();
        }

        private void BtnOthers_Click(object sender, EventArgs e)
        {
            selectedGroup = GroupSelection.Others;
            GroupSelectedClickHandler();
        }

        private void BtnToMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            Close();
        }

        private void GroupSelectionMenu_Load(object sender, EventArgs e)
        {
            switch (fileModifierOption)
            {
                case SystemOption.View:
                    lblSystemOption.Text = "View Animals by Group";
                    break;
                case SystemOption.Add:
                    lblSystemOption.Text = "Add an Animal to which group?";
                    break;
                case SystemOption.Remove:
                    lblSystemOption.Text = "Remove an Animal from which group?";
                    break;
                case SystemOption.Edit:
                    lblSystemOption.Text = "Edit an Animal in which group?";
                    break;
            }

            lblSystemOption.Location = CenterTheLabel();
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
            string instructions = "Select the group the animal is in or will be in, if you're added an animal.";

            MessageBox.Show(instructions, "Group Selection Menu Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Animal Roster Management System\n"
                         + "Created by Terence Lee for ITDEV-185 Spring 2020";

            MessageBox.Show(about, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
