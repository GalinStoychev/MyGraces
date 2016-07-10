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
            this.ReadyButtonPTwo = new System.Windows.Forms.Button();
            this.SkillListPTwo = new System.Windows.Forms.CheckedListBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.panelTeam1Body = new System.Windows.Forms.Panel();
            this.ReadyButtonPOne = new System.Windows.Forms.Button();
            this.ItemListPOne = new System.Windows.Forms.CheckedListBox();
            this.SkillListPOne = new System.Windows.Forms.CheckedListBox();
            this.panelSecondTeamName = new System.Windows.Forms.Panel();
            this.panelFirstTeamName = new System.Windows.Forms.Panel();
            this.POneName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.PTwoName = new System.Windows.Forms.Label();
            this.ItemListPTwo = new System.Windows.Forms.CheckedListBox();
            this.panelTeam2Body.SuspendLayout();
            this.panelTeam1Body.SuspendLayout();
            this.panelSecondTeamName.SuspendLayout();
            this.panelFirstTeamName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTeam2Body
            // 
            this.panelTeam2Body.BackColor = System.Drawing.Color.Brown;
            this.panelTeam2Body.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTeam2Body.Controls.Add(this.ReadyButtonPTwo);
            this.panelTeam2Body.Controls.Add(this.ItemListPTwo);
            this.panelTeam2Body.Controls.Add(this.NextButton);
            this.panelTeam2Body.Controls.Add(this.SkillListPTwo);
            this.panelTeam2Body.Location = new System.Drawing.Point(418, 94);
            this.panelTeam2Body.Margin = new System.Windows.Forms.Padding(4);
            this.panelTeam2Body.Name = "panelTeam2Body";
            this.panelTeam2Body.Size = new System.Drawing.Size(405, 399);
            this.panelTeam2Body.TabIndex = 11;
            // 
            // ReadyButtonPTwo
            // 
            this.ReadyButtonPTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ReadyButtonPTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadyButtonPTwo.ForeColor = System.Drawing.Color.White;
            this.ReadyButtonPTwo.Location = new System.Drawing.Point(101, 227);
            this.ReadyButtonPTwo.Name = "ReadyButtonPTwo";
            this.ReadyButtonPTwo.Size = new System.Drawing.Size(197, 73);
            this.ReadyButtonPTwo.TabIndex = 2;
            this.ReadyButtonPTwo.Text = "Ready";
            this.ReadyButtonPTwo.UseVisualStyleBackColor = false;
            this.ReadyButtonPTwo.Click += new System.EventHandler(this.ReadyButtonPTwo_Click);
            // 
            // SkillListPTwo
            // 
            this.SkillListPTwo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SkillListPTwo.CheckOnClick = true;
            this.SkillListPTwo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkillListPTwo.FormattingEnabled = true;
            this.SkillListPTwo.Items.AddRange(new object[] {
            "Power Mode",
            "Mesmerize",
            "Decrease Opponent Energy",
            "Energy Mode"});
            this.SkillListPTwo.Location = new System.Drawing.Point(3, 5);
            this.SkillListPTwo.Name = "SkillListPTwo";
            this.SkillListPTwo.Size = new System.Drawing.Size(391, 106);
            this.SkillListPTwo.TabIndex = 1;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.OliveDrab;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(240, 322);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(154, 64);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
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
            // ReadyButtonPOne
            // 
            this.ReadyButtonPOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ReadyButtonPOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.ReadyButtonPOne.ForeColor = System.Drawing.Color.White;
            this.ReadyButtonPOne.Location = new System.Drawing.Point(91, 227);
            this.ReadyButtonPOne.Name = "ReadyButtonPOne";
            this.ReadyButtonPOne.Size = new System.Drawing.Size(197, 73);
            this.ReadyButtonPOne.TabIndex = 7;
            this.ReadyButtonPOne.Text = "Ready";
            this.ReadyButtonPOne.UseVisualStyleBackColor = false;
            this.ReadyButtonPOne.Click += new System.EventHandler(this.ReadyButtonPOne_Click);
            // 
            // ItemListPOne
            // 
            this.ItemListPOne.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ItemListPOne.CheckOnClick = true;
            this.ItemListPOne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemListPOne.FormattingEnabled = true;
            this.ItemListPOne.Items.AddRange(new object[] {
            "Anti Glear Screen",
            "Coffee",
            "External Keyboard",
            "Mouse"});
            this.ItemListPOne.Location = new System.Drawing.Point(5, 117);
            this.ItemListPOne.Name = "ItemListPOne";
            this.ItemListPOne.Size = new System.Drawing.Size(384, 104);
            this.ItemListPOne.TabIndex = 6;
            // 
            // SkillListPOne
            // 
            this.SkillListPOne.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SkillListPOne.CheckOnClick = true;
            this.SkillListPOne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkillListPOne.FormattingEnabled = true;
            this.SkillListPOne.Items.AddRange(new object[] {
            "Power Mode",
            "Mesmerize",
            "Decrease Opponent Energy",
            "Energy Mode"});
            this.SkillListPOne.Location = new System.Drawing.Point(5, 5);
            this.SkillListPOne.Margin = new System.Windows.Forms.Padding(5);
            this.SkillListPOne.Name = "SkillListPOne";
            this.SkillListPOne.Size = new System.Drawing.Size(384, 104);
            this.SkillListPOne.TabIndex = 5;
            // 
            // panelSecondTeamName
            // 
            this.panelSecondTeamName.BackColor = System.Drawing.Color.Red;
            this.panelSecondTeamName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSecondTeamName.Controls.Add(this.PTwoName);
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
            // POneName
            // 
            this.POneName.AutoSize = true;
            this.POneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.POneName.ForeColor = System.Drawing.Color.White;
            this.POneName.Location = new System.Drawing.Point(103, 7);
            this.POneName.Name = "POneName";
            this.POneName.Size = new System.Drawing.Size(0, 58);
            this.POneName.TabIndex = 1;
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
            // PTwoName
            // 
            this.PTwoName.AutoSize = true;
            this.PTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PTwoName.ForeColor = System.Drawing.Color.White;
            this.PTwoName.Location = new System.Drawing.Point(114, 7);
            this.PTwoName.Name = "PTwoName";
            this.PTwoName.Size = new System.Drawing.Size(0, 58);
            this.PTwoName.TabIndex = 2;
            // 
            // ItemListPTwo
            // 
            this.ItemListPTwo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ItemListPTwo.CheckOnClick = true;
            this.ItemListPTwo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemListPTwo.FormattingEnabled = true;
            this.ItemListPTwo.Items.AddRange(new object[] {
            "Anti Glear Screen",
            "Coffee",
            "External Keyboard",
            "Mouse"});
            this.ItemListPTwo.Location = new System.Drawing.Point(3, 117);
            this.ItemListPTwo.Name = "ItemListPTwo";
            this.ItemListPTwo.Size = new System.Drawing.Size(391, 104);
            this.ItemListPTwo.TabIndex = 7;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skills_and_Items_Choice";
            this.panelTeam2Body.ResumeLayout(false);
            this.panelTeam1Body.ResumeLayout(false);
            this.panelSecondTeamName.ResumeLayout(false);
            this.panelSecondTeamName.PerformLayout();
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
        private System.Windows.Forms.Label PTwoName;
        private System.Windows.Forms.CheckedListBox ItemListPTwo;
    }
}