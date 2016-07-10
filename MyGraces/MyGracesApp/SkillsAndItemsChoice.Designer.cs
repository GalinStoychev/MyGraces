namespace MyGracesApp
{
    partial class SkillsAndItemsChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillsAndItemsChoice));
            this.panelTeam2Body = new System.Windows.Forms.Panel();
            this.NextButton = new System.Windows.Forms.Button();
            this.panelTeam1Body = new System.Windows.Forms.Panel();
            this.panelSecondTeamName = new System.Windows.Forms.Panel();
            this.panelFirstTeamName = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.SkillListPOne = new System.Windows.Forms.CheckedListBox();
            this.ItemListPOne = new System.Windows.Forms.CheckedListBox();
            this.ReadyButtonPOne = new System.Windows.Forms.Button();
            this.POneName = new System.Windows.Forms.Label();
            this.SkillListPTwo = new System.Windows.Forms.CheckedListBox();
            this.ReadyButtonPTwo = new System.Windows.Forms.Button();
            this.panelTeam2Body.SuspendLayout();
            this.panelTeam1Body.SuspendLayout();
            this.panelFirstTeamName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTeam2Body
            // 
            this.panelTeam2Body.BackColor = System.Drawing.Color.Brown;
            this.panelTeam2Body.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTeam2Body.Controls.Add(this.ReadyButtonPTwo);
            this.panelTeam2Body.Controls.Add(this.SkillListPTwo);
            this.panelTeam2Body.Controls.Add(this.NextButton);
            this.panelTeam2Body.Location = new System.Drawing.Point(418, 94);
            this.panelTeam2Body.Margin = new System.Windows.Forms.Padding(4);
            this.panelTeam2Body.Name = "panelTeam2Body";
            this.panelTeam2Body.Size = new System.Drawing.Size(405, 399);
            this.panelTeam2Body.TabIndex = 11;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(60, 312);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(240, 74);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // panelTeam1Body
            // 
            this.panelTeam1Body.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTeam1Body.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTeam1Body.Controls.Add(this.ReadyButtonPOne);
            this.panelTeam1Body.Controls.Add(this.ItemListPOne);
            this.panelTeam1Body.Controls.Add(this.SkillListPOne);
            this.panelTeam1Body.Location = new System.Drawing.Point(4, 94);
            this.panelTeam1Body.Margin = new System.Windows.Forms.Padding(4);
            this.panelTeam1Body.Name = "panelTeam1Body";
            this.panelTeam1Body.Size = new System.Drawing.Size(401, 399);
            this.panelTeam1Body.TabIndex = 10;
            // 
            // panelSecondTeamName
            // 
            this.panelSecondTeamName.BackColor = System.Drawing.Color.Red;
            this.panelSecondTeamName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSecondTeamName.Location = new System.Drawing.Point(418, 4);
            this.panelSecondTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.panelSecondTeamName.Name = "panelSecondTeamName";
            this.panelSecondTeamName.Size = new System.Drawing.Size(405, 82);
            this.panelSecondTeamName.TabIndex = 9;
            // 
            // panelFirstTeamName
            // 
            this.panelFirstTeamName.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelFirstTeamName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFirstTeamName.Controls.Add(this.POneName);
            this.panelFirstTeamName.Location = new System.Drawing.Point(4, 4);
            this.panelFirstTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.panelFirstTeamName.Name = "panelFirstTeamName";
            this.panelFirstTeamName.Size = new System.Drawing.Size(404, 82);
            this.panelFirstTeamName.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(713, -39);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // SkillListPOne
            // 
            this.SkillListPOne.FormattingEnabled = true;
            this.SkillListPOne.Items.AddRange(new object[] {
            "Power Mode"});
            this.SkillListPOne.Location = new System.Drawing.Point(26, 84);
            this.SkillListPOne.Name = "SkillListPOne";
            this.SkillListPOne.Size = new System.Drawing.Size(120, 89);
            this.SkillListPOne.TabIndex = 5;
            // 
            // ItemListPOne
            // 
            this.ItemListPOne.FormattingEnabled = true;
            this.ItemListPOne.Items.AddRange(new object[] {
            "Item One",
            "Item Two",
            "Item Three",
            "Item Four",
            "Item Five"});
            this.ItemListPOne.Location = new System.Drawing.Point(239, 84);
            this.ItemListPOne.Name = "ItemListPOne";
            this.ItemListPOne.Size = new System.Drawing.Size(120, 89);
            this.ItemListPOne.TabIndex = 6;
            // 
            // ReadyButtonPOne
            // 
            this.ReadyButtonPOne.Location = new System.Drawing.Point(113, 246);
            this.ReadyButtonPOne.Name = "ReadyButtonPOne";
            this.ReadyButtonPOne.Size = new System.Drawing.Size(158, 85);
            this.ReadyButtonPOne.TabIndex = 7;
            this.ReadyButtonPOne.Text = "Ready";
            this.ReadyButtonPOne.UseVisualStyleBackColor = true;
            this.ReadyButtonPOne.Click += new System.EventHandler(this.ReadyButtonPOne_Click);
            // 
            // POneName
            // 
            this.POneName.AutoSize = true;
            this.POneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.POneName.Location = new System.Drawing.Point(135, 30);
            this.POneName.Name = "POneName";
            this.POneName.Size = new System.Drawing.Size(0, 29);
            this.POneName.TabIndex = 1;
            // 
            // SkillListPTwo
            // 
            this.SkillListPTwo.FormattingEnabled = true;
            this.SkillListPTwo.Items.AddRange(new object[] {
            "Power Mode",
            "Mesmerize",
            "Decrease Opponent Energy"});
            this.SkillListPTwo.Location = new System.Drawing.Point(35, 37);
            this.SkillListPTwo.Name = "SkillListPTwo";
            this.SkillListPTwo.Size = new System.Drawing.Size(120, 89);
            this.SkillListPTwo.TabIndex = 1;
            // 
            // ReadyButtonPTwo
            // 
            this.ReadyButtonPTwo.Location = new System.Drawing.Point(114, 203);
            this.ReadyButtonPTwo.Name = "ReadyButtonPTwo";
            this.ReadyButtonPTwo.Size = new System.Drawing.Size(164, 78);
            this.ReadyButtonPTwo.TabIndex = 2;
            this.ReadyButtonPTwo.Text = "Ready";
            this.ReadyButtonPTwo.UseVisualStyleBackColor = true;
            this.ReadyButtonPTwo.Click += new System.EventHandler(this.ReadyButtonPTwo_Click);
            // 
            // SkillsAndItemsChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 494);
            this.Controls.Add(this.panelTeam2Body);
            this.Controls.Add(this.panelTeam1Body);
            this.Controls.Add(this.panelSecondTeamName);
            this.Controls.Add(this.panelFirstTeamName);
            this.Controls.Add(this.btnExit);
            this.Name = "SkillsAndItemsChoice";
            this.Text = "Skills_and_Items_Choice";
            this.panelTeam2Body.ResumeLayout(false);
            this.panelTeam1Body.ResumeLayout(false);
            this.panelFirstTeamName.ResumeLayout(false);
            this.panelFirstTeamName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTeam2Body;
        private System.Windows.Forms.Panel panelTeam1Body;
        private System.Windows.Forms.Panel panelSecondTeamName;
        private System.Windows.Forms.Panel panelFirstTeamName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.CheckedListBox SkillListPOne;
        private System.Windows.Forms.CheckedListBox ItemListPOne;
        private System.Windows.Forms.Button ReadyButtonPOne;
        private System.Windows.Forms.Label POneName;
        private System.Windows.Forms.CheckedListBox SkillListPTwo;
        private System.Windows.Forms.Button ReadyButtonPTwo;
    }
}