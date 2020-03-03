using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using static AnimalRosterManagerApp.GroupSelectionMenu;
using static AnimalRosterManagerApp.MainMenu;

namespace AnimalRosterManagerApp
{
    public partial class AddForm : Form
    {
        private readonly GroupSelection selectedGroup;

        public AddForm(GroupSelection group)
        {
            InitializeComponent();
            selectedGroup = group;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Add New Animal"; //Title of this form when user selects the all others group
            
            /*
             * Controls displaying the appropriate unique questions panel.
             * Also, changes the name of the form's title label.
             */
            switch (selectedGroup)
            {
                case GroupSelection.Birds:
                    lblTitle.Text = "Add New Bird";
                    pnlUniqueBirdQuestion.Visible = true;
                    break;
                case GroupSelection.Reptiles:
                    lblTitle.Text = "Add New Reptile";
                    pnlUniqueReptileQuestions.Visible = true;
                    break;
                case GroupSelection.Mammals:
                    lblTitle.Text = "Add New Mammal";
                    pnlUniqueMammalQuestions.Visible = true;
                    break;
            }

            lblTitle.Location = CenterTheLabel();
        }

        private Point CenterTheLabel()
        {
            int y = (Height / 10) - (lblTitle.Height / 2);
            int x = (Width / 2) - (lblTitle.Width / 2);
            return new Point(x, y);
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            if(ValidatedUserEnteredData())
            {
                StreamWriter outStream = new StreamWriter(AnimalDataFileLocation(selectedGroup), false);

                outStream.WriteLine(txtBxName.Text);
                outStream.WriteLine(txtBxAge.Text);
                outStream.WriteLine(cmbBxGender.SelectedItem);
                outStream.WriteLine(txtBxLocation.Text);
                outStream.WriteLine(txtBxType.Text);
                outStream.WriteLine(cmbBxDietType.SelectedItem);
                outStream.WriteLine(txtBxMovement.Text);

                switch (selectedGroup)
                {
                    case GroupSelection.Birds:
                        outStream.WriteLine(cmbBxIsTagged.SelectedItem);
                        break;
                    case GroupSelection.Reptiles:
                        outStream.WriteLine(cmbBxHasAShell.SelectedItem);
                        outStream.WriteLine(cmbBxLivesIndoors.SelectedItem);
                        break;
                    case GroupSelection.Mammals:
                        outStream.WriteLine(txtBxWeight.Text);
                        outStream.WriteLine(cmbBxDailyMeal.SelectedItem);
                        break;
                }

                outStream.WriteLine();
                outStream.Close();

                MessageBox.Show("Animal was successfully added to roster!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Clearing the fields
                txtBxName.Text = "";
                txtBxAge.Text = "";
                cmbBxGender.SelectedItem = null;
                txtBxLocation.Text = "";
                txtBxType.Text = "";
                cmbBxDietType.SelectedItem = null;
                txtBxMovement.Text = "";

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
                        txtBxWeight.Text = "";
                        cmbBxDailyMeal.SelectedItem = null;
                        break;
                }
            }
        }

        private bool ValidatedUserEnteredData()
        {
            Control controlToFocusOn = new Control();
            string validationFailureMessage = null;

            switch(selectedGroup)
            {
                case GroupSelection.Birds:
                    if(cmbBxIsTagged.SelectedItem == null)
                    {
                        validationFailureMessage = "Please select if the bird is tagged.";
                        controlToFocusOn = cmbBxIsTagged;
                    }
                    break;
                case GroupSelection.Reptiles:
                    if(cmbBxLivesIndoors.SelectedItem == null)
                    {
                        validationFailureMessage = "Please select if the reptile lives indoors.";
                        controlToFocusOn = cmbBxLivesIndoors;
                    }
                    if(cmbBxHasAShell.SelectedItem == null)
                    {
                        validationFailureMessage = "Please select if the reptile has a shell.\n" + validationFailureMessage;
                        controlToFocusOn = cmbBxHasAShell;
                    }
                    break;
                case GroupSelection.Mammals:
                    if(cmbBxDailyMeal.SelectedItem == null)
                    {
                        validationFailureMessage = "Please select the number of meals that the animal eats per day.\n";
                        controlToFocusOn = cmbBxDailyMeal;
                    }
                    if(string.IsNullOrWhiteSpace(txtBxWeight.Text) || !double.TryParse(txtBxWeight.Text, out double weight) || weight <= 0.0)
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
            if(string.IsNullOrWhiteSpace(txtBxAge.Text) || !int.TryParse(txtBxAge.Text, out int age) || age <= 0)
            {
                validationFailureMessage = "Please enter a value, 1 or greater, for age.\n" + validationFailureMessage;
                controlToFocusOn = txtBxAge;
            }
            if(string.IsNullOrWhiteSpace(txtBxName.Text))
            {
                validationFailureMessage = "Please enter a name for the animal.\n" + validationFailureMessage;
                controlToFocusOn = txtBxName;
            }

            if(validationFailureMessage == null)
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
            new GroupSelectionMenu(SystemOption.Add).ShowDialog();
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
            string instructions = "Fill in all the fields with valid data, then click \"Add Animal\" to save the new animal.";

            MessageBox.Show(instructions, "Add Animal Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Animal Roster Management System\n"
                         + "Created by Terence Lee for ITDEV-185 Spring 2020";

            MessageBox.Show(about, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
