using System;
using System.IO;
using System.Windows.Forms;
using static AnimalRosterManagerApp.GroupSelectionMenu;

namespace AnimalRosterManagerApp
{
    public partial class MainMenu : Form
    {
        public enum SystemOption
        {
            View,
            Add,
            Remove,
            Edit
        }

        public MainMenu()
        {
            InitializeComponent();

            if (!File.Exists(AnimalDataFileLocation(GroupSelection.Others)))
            {
                File.Create(AnimalDataFileLocation(GroupSelection.Others));
            }
            if (!File.Exists(AnimalDataFileLocation(GroupSelection.Birds)))
            {
                File.Create(AnimalDataFileLocation(GroupSelection.Birds));
            }
            if (!File.Exists(AnimalDataFileLocation(GroupSelection.Reptiles)))
            {
                File.Create(AnimalDataFileLocation(GroupSelection.Reptiles));
            }
            if(!File.Exists(AnimalDataFileLocation(GroupSelection.Mammals)))
            {
                File.Create(AnimalDataFileLocation(GroupSelection.Mammals));
            }
        }

        public static string AnimalDataFileLocation(GroupSelection group)
        {
            switch (group)
            {
                case GroupSelection.Birds:
                    return @"../../DataFiles/Birds.txt";
                case GroupSelection.Reptiles:
                    return @"../../DataFiles/Reptiles.txt";
                case GroupSelection.Mammals:
                    return @"../../DataFiles/Mammals.txt";
                case GroupSelection.Others:
                    return @"../../DataFiles/Others.txt";
            }

            return "";
        }
        private void BtnViewAnimals_Click(object sender, EventArgs e)
        {
            Hide();
            GroupSelectionMenu groupMenu = new GroupSelectionMenu(SystemOption.View);
            groupMenu.ShowDialog();
            Close();
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            Hide();
            GroupSelectionMenu groupMenu = new GroupSelectionMenu(SystemOption.Add);
            groupMenu.ShowDialog();
            Close();
        }

        private void BtnRemoveAnimal_Click(object sender, EventArgs e)
        {
            Hide();
            GroupSelectionMenu groupMenu = new GroupSelectionMenu(SystemOption.Remove);
            groupMenu.ShowDialog();
            Close();
        }

        private void BtnEditAnimal_Click(object sender, EventArgs e)
        {
            Hide();
            GroupSelectionMenu groupMenu = new GroupSelectionMenu(SystemOption.Edit);
            groupMenu.ShowDialog();
            Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult userAnswer;
            userAnswer = MessageBox.Show("Are you sure you want to close the program?", "Leaving?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userAnswer == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnExit_Click(sender, e);
        }

        private void InstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string instructions = "Select an option by clicking on the appropriate button.";

            MessageBox.Show(instructions, "Main Menu Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Animal Roster Management System\n"
                         + "Created by Terence Lee for ITDEV-185 Spring 2020";

            MessageBox.Show(about, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
