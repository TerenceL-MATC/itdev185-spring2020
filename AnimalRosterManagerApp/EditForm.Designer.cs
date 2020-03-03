namespace AnimalRosterManagerApp
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnGroupSelection = new System.Windows.Forms.Button();
            this.btnSaveEdits = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstBxAnimalNames = new System.Windows.Forms.ListBox();
            this.pnlUniqueBirdQuestion = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbBxIsTagged = new System.Windows.Forms.ComboBox();
            this.pnlUniqueMammalQuestions = new System.Windows.Forms.Panel();
            this.txtBxWeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlUniqueReptileQuestions = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBxLivesIndoors = new System.Windows.Forms.ComboBox();
            this.cmbBxHasAShell = new System.Windows.Forms.ComboBox();
            this.cmbBxGender = new System.Windows.Forms.ComboBox();
            this.cmbBxDietType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxMovement = new System.Windows.Forms.TextBox();
            this.txtBxType = new System.Windows.Forms.TextBox();
            this.txtBxLocation = new System.Windows.Forms.TextBox();
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.cmbBxDailyMeal = new System.Windows.Forms.ComboBox();
            this.menuStrip2.SuspendLayout();
            this.pnlUniqueBirdQuestion.SuspendLayout();
            this.pnlUniqueMammalQuestions.SuspendLayout();
            this.pnlUniqueReptileQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1240, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.InstructionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(691, 558);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(296, 37);
            this.btnMainMenu.TabIndex = 24;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // btnGroupSelection
            // 
            this.btnGroupSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupSelection.Location = new System.Drawing.Point(254, 558);
            this.btnGroupSelection.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupSelection.Name = "btnGroupSelection";
            this.btnGroupSelection.Size = new System.Drawing.Size(296, 37);
            this.btnGroupSelection.TabIndex = 23;
            this.btnGroupSelection.Text = "Group Selection Menu";
            this.btnGroupSelection.UseVisualStyleBackColor = true;
            this.btnGroupSelection.Click += new System.EventHandler(this.BtnGroupSelection_Click);
            // 
            // btnSaveEdits
            // 
            this.btnSaveEdits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdits.Location = new System.Drawing.Point(506, 476);
            this.btnSaveEdits.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEdits.Name = "btnSaveEdits";
            this.btnSaveEdits.Size = new System.Drawing.Size(229, 42);
            this.btnSaveEdits.TabIndex = 22;
            this.btnSaveEdits.Text = "Save Changes";
            this.btnSaveEdits.UseVisualStyleBackColor = true;
            this.btnSaveEdits.Click += new System.EventHandler(this.BtnSaveEdits_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(620, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 37);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBxAnimalNames
            // 
            this.lstBxAnimalNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxAnimalNames.FormattingEnabled = true;
            this.lstBxAnimalNames.ItemHeight = 24;
            this.lstBxAnimalNames.Location = new System.Drawing.Point(43, 106);
            this.lstBxAnimalNames.Margin = new System.Windows.Forms.Padding(4);
            this.lstBxAnimalNames.Name = "lstBxAnimalNames";
            this.lstBxAnimalNames.Size = new System.Drawing.Size(193, 340);
            this.lstBxAnimalNames.TabIndex = 20;
            this.lstBxAnimalNames.SelectedIndexChanged += new System.EventHandler(this.LstBxAnimalNames_SelectedIndexChanged);
            // 
            // pnlUniqueBirdQuestion
            // 
            this.pnlUniqueBirdQuestion.Controls.Add(this.label13);
            this.pnlUniqueBirdQuestion.Controls.Add(this.cmbBxIsTagged);
            this.pnlUniqueBirdQuestion.Location = new System.Drawing.Point(745, 284);
            this.pnlUniqueBirdQuestion.Name = "pnlUniqueBirdQuestion";
            this.pnlUniqueBirdQuestion.Size = new System.Drawing.Size(200, 61);
            this.pnlUniqueBirdQuestion.TabIndex = 44;
            this.pnlUniqueBirdQuestion.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Is Tagged?";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBxIsTagged
            // 
            this.cmbBxIsTagged.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxIsTagged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxIsTagged.FormattingEnabled = true;
            this.cmbBxIsTagged.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbBxIsTagged.Location = new System.Drawing.Point(126, 17);
            this.cmbBxIsTagged.Name = "cmbBxIsTagged";
            this.cmbBxIsTagged.Size = new System.Drawing.Size(59, 28);
            this.cmbBxIsTagged.TabIndex = 23;
            // 
            // pnlUniqueMammalQuestions
            // 
            this.pnlUniqueMammalQuestions.Controls.Add(this.cmbBxDailyMeal);
            this.pnlUniqueMammalQuestions.Controls.Add(this.txtBxWeight);
            this.pnlUniqueMammalQuestions.Controls.Add(this.label10);
            this.pnlUniqueMammalQuestions.Controls.Add(this.label11);
            this.pnlUniqueMammalQuestions.Location = new System.Drawing.Point(706, 284);
            this.pnlUniqueMammalQuestions.Name = "pnlUniqueMammalQuestions";
            this.pnlUniqueMammalQuestions.Size = new System.Drawing.Size(300, 133);
            this.pnlUniqueMammalQuestions.TabIndex = 43;
            this.pnlUniqueMammalQuestions.Visible = false;
            // 
            // txtBxWeight
            // 
            this.txtBxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxWeight.Location = new System.Drawing.Point(167, 21);
            this.txtBxWeight.Name = "txtBxWeight";
            this.txtBxWeight.Size = new System.Drawing.Size(119, 26);
            this.txtBxWeight.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "# of Meals Daily?";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Weight (in pounds)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlUniqueReptileQuestions
            // 
            this.pnlUniqueReptileQuestions.Controls.Add(this.label9);
            this.pnlUniqueReptileQuestions.Controls.Add(this.label8);
            this.pnlUniqueReptileQuestions.Controls.Add(this.cmbBxLivesIndoors);
            this.pnlUniqueReptileQuestions.Controls.Add(this.cmbBxHasAShell);
            this.pnlUniqueReptileQuestions.Location = new System.Drawing.Point(730, 284);
            this.pnlUniqueReptileQuestions.Name = "pnlUniqueReptileQuestions";
            this.pnlUniqueReptileQuestions.Size = new System.Drawing.Size(248, 133);
            this.pnlUniqueReptileQuestions.TabIndex = 42;
            this.pnlUniqueReptileQuestions.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Lives Indoors?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Has A Shell?";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBxLivesIndoors
            // 
            this.cmbBxLivesIndoors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxLivesIndoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxLivesIndoors.FormattingEnabled = true;
            this.cmbBxLivesIndoors.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbBxLivesIndoors.Location = new System.Drawing.Point(143, 81);
            this.cmbBxLivesIndoors.Name = "cmbBxLivesIndoors";
            this.cmbBxLivesIndoors.Size = new System.Drawing.Size(85, 28);
            this.cmbBxLivesIndoors.TabIndex = 24;
            // 
            // cmbBxHasAShell
            // 
            this.cmbBxHasAShell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxHasAShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxHasAShell.FormattingEnabled = true;
            this.cmbBxHasAShell.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbBxHasAShell.Location = new System.Drawing.Point(143, 24);
            this.cmbBxHasAShell.Name = "cmbBxHasAShell";
            this.cmbBxHasAShell.Size = new System.Drawing.Size(85, 28);
            this.cmbBxHasAShell.TabIndex = 23;
            // 
            // cmbBxGender
            // 
            this.cmbBxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxGender.FormattingEnabled = true;
            this.cmbBxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBxGender.Location = new System.Drawing.Point(377, 240);
            this.cmbBxGender.Name = "cmbBxGender";
            this.cmbBxGender.Size = new System.Drawing.Size(102, 28);
            this.cmbBxGender.TabIndex = 41;
            // 
            // cmbBxDietType
            // 
            this.cmbBxDietType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxDietType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxDietType.FormattingEnabled = true;
            this.cmbBxDietType.Items.AddRange(new object[] {
            "Omnivore",
            "Carnivore",
            "Herbivore"});
            this.cmbBxDietType.Location = new System.Drawing.Point(873, 108);
            this.cmbBxDietType.Name = "cmbBxDietType";
            this.cmbBxDietType.Size = new System.Drawing.Size(133, 28);
            this.cmbBxDietType.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(733, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "How They Move";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Diet Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Zoo Location";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Gender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Age";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBxMovement
            // 
            this.txtBxMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMovement.Location = new System.Drawing.Point(873, 166);
            this.txtBxMovement.Multiline = true;
            this.txtBxMovement.Name = "txtBxMovement";
            this.txtBxMovement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxMovement.Size = new System.Drawing.Size(325, 112);
            this.txtBxMovement.TabIndex = 32;
            // 
            // txtBxType
            // 
            this.txtBxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxType.Location = new System.Drawing.Point(377, 370);
            this.txtBxType.MaxLength = 50;
            this.txtBxType.Name = "txtBxType";
            this.txtBxType.Size = new System.Drawing.Size(309, 26);
            this.txtBxType.TabIndex = 31;
            // 
            // txtBxLocation
            // 
            this.txtBxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxLocation.Location = new System.Drawing.Point(377, 304);
            this.txtBxLocation.MaxLength = 50;
            this.txtBxLocation.Name = "txtBxLocation";
            this.txtBxLocation.Size = new System.Drawing.Size(309, 26);
            this.txtBxLocation.TabIndex = 30;
            // 
            // txtBxAge
            // 
            this.txtBxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxAge.Location = new System.Drawing.Point(377, 172);
            this.txtBxAge.MaxLength = 3;
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.Size = new System.Drawing.Size(68, 26);
            this.txtBxAge.TabIndex = 29;
            // 
            // txtBxName
            // 
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxName.Location = new System.Drawing.Point(377, 106);
            this.txtBxName.MaxLength = 30;
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(325, 26);
            this.txtBxName.TabIndex = 28;
            // 
            // cmbBxDailyMeal
            // 
            this.cmbBxDailyMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxDailyMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxDailyMeal.FormattingEnabled = true;
            this.cmbBxDailyMeal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbBxDailyMeal.Location = new System.Drawing.Point(167, 75);
            this.cmbBxDailyMeal.Name = "cmbBxDailyMeal";
            this.cmbBxDailyMeal.Size = new System.Drawing.Size(59, 28);
            this.cmbBxDailyMeal.TabIndex = 26;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 633);
            this.Controls.Add(this.pnlUniqueBirdQuestion);
            this.Controls.Add(this.pnlUniqueMammalQuestions);
            this.Controls.Add(this.pnlUniqueReptileQuestions);
            this.Controls.Add(this.cmbBxGender);
            this.Controls.Add(this.cmbBxDietType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxMovement);
            this.Controls.Add(this.txtBxType);
            this.Controls.Add(this.txtBxLocation);
            this.Controls.Add(this.txtBxAge);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnGroupSelection);
            this.Controls.Add(this.btnSaveEdits);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstBxAnimalNames);
            this.Controls.Add(this.menuStrip2);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit an Animal - Animal Roster Management System";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pnlUniqueBirdQuestion.ResumeLayout(false);
            this.pnlUniqueBirdQuestion.PerformLayout();
            this.pnlUniqueMammalQuestions.ResumeLayout(false);
            this.pnlUniqueMammalQuestions.PerformLayout();
            this.pnlUniqueReptileQuestions.ResumeLayout(false);
            this.pnlUniqueReptileQuestions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnGroupSelection;
        private System.Windows.Forms.Button btnSaveEdits;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstBxAnimalNames;
        private System.Windows.Forms.Panel pnlUniqueBirdQuestion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbBxIsTagged;
        private System.Windows.Forms.Panel pnlUniqueMammalQuestions;
        private System.Windows.Forms.TextBox txtBxWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlUniqueReptileQuestions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBxLivesIndoors;
        private System.Windows.Forms.ComboBox cmbBxHasAShell;
        private System.Windows.Forms.ComboBox cmbBxGender;
        private System.Windows.Forms.ComboBox cmbBxDietType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxMovement;
        private System.Windows.Forms.TextBox txtBxType;
        private System.Windows.Forms.TextBox txtBxLocation;
        private System.Windows.Forms.TextBox txtBxAge;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.ComboBox cmbBxDailyMeal;
    }
}