namespace AnimalRosterManagerApp
{
    partial class GroupSelectionMenu
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
            this.lblSystemOption = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBirds = new System.Windows.Forms.Button();
            this.btnToMainMenu = new System.Windows.Forms.Button();
            this.btnOthers = new System.Windows.Forms.Button();
            this.btnMammals = new System.Windows.Forms.Button();
            this.btnReptiles = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSystemOption
            // 
            this.lblSystemOption.AutoSize = true;
            this.lblSystemOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemOption.Location = new System.Drawing.Point(400, 44);
            this.lblSystemOption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemOption.Name = "lblSystemOption";
            this.lblSystemOption.Size = new System.Drawing.Size(0, 37);
            this.lblSystemOption.TabIndex = 21;
            this.lblSystemOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            // btnBirds
            // 
            this.btnBirds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBirds.Location = new System.Drawing.Point(230, 128);
            this.btnBirds.Margin = new System.Windows.Forms.Padding(4);
            this.btnBirds.Name = "btnBirds";
            this.btnBirds.Size = new System.Drawing.Size(340, 53);
            this.btnBirds.TabIndex = 19;
            this.btnBirds.Text = "Birds";
            this.btnBirds.UseVisualStyleBackColor = true;
            this.btnBirds.Click += new System.EventHandler(this.BtnBirds_Click);
            // 
            // btnToMainMenu
            // 
            this.btnToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToMainMenu.Location = new System.Drawing.Point(230, 435);
            this.btnToMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnToMainMenu.Name = "btnToMainMenu";
            this.btnToMainMenu.Size = new System.Drawing.Size(340, 53);
            this.btnToMainMenu.TabIndex = 18;
            this.btnToMainMenu.Text = "Back to Main Menu";
            this.btnToMainMenu.UseVisualStyleBackColor = true;
            this.btnToMainMenu.Click += new System.EventHandler(this.BtnToMainMenu_Click);
            // 
            // btnOthers
            // 
            this.btnOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.Location = new System.Drawing.Point(230, 362);
            this.btnOthers.Margin = new System.Windows.Forms.Padding(4);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(340, 53);
            this.btnOthers.TabIndex = 17;
            this.btnOthers.Text = "All Others";
            this.btnOthers.UseVisualStyleBackColor = true;
            this.btnOthers.Click += new System.EventHandler(this.BtnOthers_Click);
            // 
            // btnMammals
            // 
            this.btnMammals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMammals.Location = new System.Drawing.Point(230, 284);
            this.btnMammals.Margin = new System.Windows.Forms.Padding(4);
            this.btnMammals.Name = "btnMammals";
            this.btnMammals.Size = new System.Drawing.Size(340, 53);
            this.btnMammals.TabIndex = 16;
            this.btnMammals.Text = "Mammals";
            this.btnMammals.UseVisualStyleBackColor = true;
            this.btnMammals.Click += new System.EventHandler(this.BtnMammals_Click);
            // 
            // btnReptiles
            // 
            this.btnReptiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReptiles.Location = new System.Drawing.Point(230, 208);
            this.btnReptiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnReptiles.Name = "btnReptiles";
            this.btnReptiles.Size = new System.Drawing.Size(340, 53);
            this.btnReptiles.TabIndex = 15;
            this.btnReptiles.Text = "Reptiles";
            this.btnReptiles.UseVisualStyleBackColor = true;
            this.btnReptiles.Click += new System.EventHandler(this.BtnReptiles_Click);
            // 
            // GroupSelectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.lblSystemOption);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnBirds);
            this.Controls.Add(this.btnToMainMenu);
            this.Controls.Add(this.btnOthers);
            this.Controls.Add(this.btnMammals);
            this.Controls.Add(this.btnReptiles);
            this.Name = "GroupSelectionMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group Selection Menu - Animal Roster Management System";
            this.Load += new System.EventHandler(this.GroupSelectionMenu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSystemOption;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnBirds;
        private System.Windows.Forms.Button btnToMainMenu;
        private System.Windows.Forms.Button btnOthers;
        private System.Windows.Forms.Button btnMammals;
        private System.Windows.Forms.Button btnReptiles;
    }
}