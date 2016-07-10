namespace MyGracesApp
{
    partial class InitializeTheBeginnig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitializeTheBeginnig));
            this.canvasSeparator = new System.Windows.Forms.Panel();
            this.panelFirstTeamName = new System.Windows.Forms.Panel();
            this.panelSecondTeamName = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelTeam1Body = new System.Windows.Forms.Panel();
            this.comboBox_PlayerOne = new System.Windows.Forms.ComboBox();
            this.FirstHeroNameTBox = new System.Windows.Forms.TextBox();
            this.PlayerOneLabel = new System.Windows.Forms.Label();
            this.PlayerTwoLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.SecondHeroNameTBox = new System.Windows.Forms.TextBox();
            this.comboBox_PlayerTwo = new System.Windows.Forms.ComboBox();
            this.panelTeam2Body = new System.Windows.Forms.Panel();
            this.panelFirstTeamName.SuspendLayout();
            this.panelSecondTeamName.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.panelTeam1Body.SuspendLayout();
            this.panelTeam2Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvasSeparator
            // 
            this.canvasSeparator.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.canvasSeparator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.canvasSeparator.Location = new System.Drawing.Point(412, 0);
            this.canvasSeparator.Margin = new System.Windows.Forms.Padding(4);
            this.canvasSeparator.Name = "canvasSeparator";
            this.canvasSeparator.Size = new System.Drawing.Size(3, 566);
            this.canvasSeparator.TabIndex = 0;
            // 
            // panelFirstTeamName
            // 
            this.panelFirstTeamName.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelFirstTeamName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFirstTeamName.Controls.Add(this.PlayerOneLabel);
            this.panelFirstTeamName.Location = new System.Drawing.Point(5, 60);
            this.panelFirstTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.panelFirstTeamName.Name = "panelFirstTeamName";
            this.panelFirstTeamName.Size = new System.Drawing.Size(404, 82);
            this.panelFirstTeamName.TabIndex = 1;
            // 
            // panelSecondTeamName
            // 
            this.panelSecondTeamName.BackColor = System.Drawing.Color.Red;
            this.panelSecondTeamName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSecondTeamName.Controls.Add(this.PlayerTwoLabel);
            this.panelSecondTeamName.Location = new System.Drawing.Point(419, 60);
            this.panelSecondTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.panelSecondTeamName.Name = "panelSecondTeamName";
            this.panelSecondTeamName.Size = new System.Drawing.Size(405, 82);
            this.panelSecondTeamName.TabIndex = 2;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelTopBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTopBar.Controls.Add(this.lblCaption);
            this.panelTopBar.Controls.Add(this.btnExit);
            this.panelTopBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelTopBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTopBar.Location = new System.Drawing.Point(5, 5);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(819, 47);
            this.panelTopBar.TabIndex = 3;
            // 
            // lblCaption
            // 
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaption.Location = new System.Drawing.Point(236, 7);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(357, 28);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "PREPARE YOUR PLAYERS";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(756, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelTeam1Body
            // 
            this.panelTeam1Body.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTeam1Body.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTeam1Body.Controls.Add(this.comboBox_PlayerOne);
            this.panelTeam1Body.Controls.Add(this.FirstHeroNameTBox);
            this.panelTeam1Body.Location = new System.Drawing.Point(5, 150);
            this.panelTeam1Body.Margin = new System.Windows.Forms.Padding(4);
            this.panelTeam1Body.Name = "panelTeam1Body";
            this.panelTeam1Body.Size = new System.Drawing.Size(401, 399);
            this.panelTeam1Body.TabIndex = 4;
            // 
            // comboBox_PlayerOne
            // 
            this.comboBox_PlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_PlayerOne.FormattingEnabled = true;
            this.comboBox_PlayerOne.Items.AddRange(new object[] {
            "Cozy Dev",
            "Hack Dev",
            "Teleric Academy Dev"});
            this.comboBox_PlayerOne.Location = new System.Drawing.Point(68, 82);
            this.comboBox_PlayerOne.Name = "comboBox_PlayerOne";
            this.comboBox_PlayerOne.Size = new System.Drawing.Size(160, 37);
            this.comboBox_PlayerOne.TabIndex = 3;
            // 
            // FirstHeroNameTBox
            // 
            this.FirstHeroNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstHeroNameTBox.Location = new System.Drawing.Point(68, 17);
            this.FirstHeroNameTBox.Multiline = true;
            this.FirstHeroNameTBox.Name = "FirstHeroNameTBox";
            this.FirstHeroNameTBox.Size = new System.Drawing.Size(240, 40);
            this.FirstHeroNameTBox.TabIndex = 2;
            // 
            // PlayerOneLabel
            // 
            this.PlayerOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerOneLabel.ForeColor = System.Drawing.Color.White;
            this.PlayerOneLabel.Location = new System.Drawing.Point(22, 25);
            this.PlayerOneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerOneLabel.Name = "PlayerOneLabel";
            this.PlayerOneLabel.Size = new System.Drawing.Size(357, 28);
            this.PlayerOneLabel.TabIndex = 2;
            this.PlayerOneLabel.Text = "PLAYER ONE";
            this.PlayerOneLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayerTwoLabel
            // 
            this.PlayerTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerTwoLabel.ForeColor = System.Drawing.Color.White;
            this.PlayerTwoLabel.Location = new System.Drawing.Point(22, 25);
            this.PlayerTwoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerTwoLabel.Name = "PlayerTwoLabel";
            this.PlayerTwoLabel.Size = new System.Drawing.Size(357, 28);
            this.PlayerTwoLabel.TabIndex = 3;
            this.PlayerTwoLabel.Text = "PLAYER TWO";
            this.PlayerTwoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.OliveDrab;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(261, 329);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(136, 63);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextForm_Click);
            // 
            // SecondHeroNameTBox
            // 
            this.SecondHeroNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondHeroNameTBox.Location = new System.Drawing.Point(81, 17);
            this.SecondHeroNameTBox.Multiline = true;
            this.SecondHeroNameTBox.Name = "SecondHeroNameTBox";
            this.SecondHeroNameTBox.Size = new System.Drawing.Size(240, 40);
            this.SecondHeroNameTBox.TabIndex = 4;
            // 
            // comboBox_PlayerTwo
            // 
            this.comboBox_PlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_PlayerTwo.FormattingEnabled = true;
            this.comboBox_PlayerTwo.Items.AddRange(new object[] {
            "Cozy Dev",
            "Hack Dev",
            "Teleric Academy Dev"});
            this.comboBox_PlayerTwo.Location = new System.Drawing.Point(81, 82);
            this.comboBox_PlayerTwo.Name = "comboBox_PlayerTwo";
            this.comboBox_PlayerTwo.Size = new System.Drawing.Size(160, 37);
            this.comboBox_PlayerTwo.TabIndex = 5;
            // 
            // panelTeam2Body
            // 
            this.panelTeam2Body.BackColor = System.Drawing.Color.Brown;
            this.panelTeam2Body.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTeam2Body.Controls.Add(this.NextButton);
            this.panelTeam2Body.Controls.Add(this.comboBox_PlayerTwo);
            this.panelTeam2Body.Controls.Add(this.SecondHeroNameTBox);
            this.panelTeam2Body.Location = new System.Drawing.Point(419, 150);
            this.panelTeam2Body.Margin = new System.Windows.Forms.Padding(4);
            this.panelTeam2Body.Name = "panelTeam2Body";
            this.panelTeam2Body.Size = new System.Drawing.Size(405, 399);
            this.panelTeam2Body.TabIndex = 5;
            // 
            // InitializeTheBeginnig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(829, 565);
            this.ControlBox = false;
            this.Controls.Add(this.panelTeam2Body);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelSecondTeamName);
            this.Controls.Add(this.panelFirstTeamName);
            this.Controls.Add(this.canvasSeparator);
            this.Controls.Add(this.panelTeam1Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(829, 565);
            this.Name = "InitializeTheBeginnig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prepare your teams";
            this.panelFirstTeamName.ResumeLayout(false);
            this.panelSecondTeamName.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTeam1Body.ResumeLayout(false);
            this.panelTeam1Body.PerformLayout();
            this.panelTeam2Body.ResumeLayout(false);
            this.panelTeam2Body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvasSeparator;
        private System.Windows.Forms.Panel panelFirstTeamName;
        private System.Windows.Forms.Panel panelSecondTeamName;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel panelTeam1Body;
        private System.Windows.Forms.Label HeroNameToEnter;
        private System.Windows.Forms.TextBox FirstHeroNameTBox;
        private System.Windows.Forms.ComboBox comboBox_PlayerOne;
        private System.Windows.Forms.Label PlayerOneLabel;
        private System.Windows.Forms.Label PlayerTwoLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox SecondHeroNameTBox;
        private System.Windows.Forms.ComboBox comboBox_PlayerTwo;
        private System.Windows.Forms.Panel panelTeam2Body;
    }
}