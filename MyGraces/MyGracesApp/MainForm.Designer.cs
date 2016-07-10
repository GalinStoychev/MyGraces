namespace MyGracesApp
{
    partial class MainForm
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
            this.PlayerOnePBar = new System.Windows.Forms.ProgressBar();
            this.FightButton = new System.Windows.Forms.Button();
            this.PlayerTwoPBar = new System.Windows.Forms.ProgressBar();
            this.PlayerOneUsedSKillLabel = new System.Windows.Forms.Label();
            this.PlayerTwoUsedSKillLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PlayerOneItemLabel = new System.Windows.Forms.Label();
            this.PlayerTwoItemLabel = new System.Windows.Forms.Label();
            this.PlayerOneCodingSpeed = new System.Windows.Forms.Label();
            this.PlayerTwoCodingSpeed = new System.Windows.Forms.Label();
            this.POneName = new System.Windows.Forms.Label();
            this.PTwoName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerOneComment = new System.Windows.Forms.Label();
            this.PlayerTwoComment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerOnePBar
            // 
            this.PlayerOnePBar.BackColor = System.Drawing.SystemColors.Window;
            this.PlayerOnePBar.Location = new System.Drawing.Point(12, 45);
            this.PlayerOnePBar.Name = "PlayerOnePBar";
            this.PlayerOnePBar.Size = new System.Drawing.Size(450, 40);
            this.PlayerOnePBar.TabIndex = 0;
            // 
            // FightButton
            // 
            this.FightButton.BackColor = System.Drawing.Color.Crimson;
            this.FightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.FightButton.ForeColor = System.Drawing.SystemColors.Window;
            this.FightButton.Location = new System.Drawing.Point(576, 27);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(145, 50);
            this.FightButton.TabIndex = 1;
            this.FightButton.Text = "GO";
            this.FightButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.FightButton.UseVisualStyleBackColor = false;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // PlayerTwoPBar
            // 
            this.PlayerTwoPBar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PlayerTwoPBar.Location = new System.Drawing.Point(819, 45);
            this.PlayerTwoPBar.Name = "PlayerTwoPBar";
            this.PlayerTwoPBar.Size = new System.Drawing.Size(450, 40);
            this.PlayerTwoPBar.TabIndex = 2;
            // 
            // PlayerOneUsedSKillLabel
            // 
            this.PlayerOneUsedSKillLabel.AutoSize = true;
            this.PlayerOneUsedSKillLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PlayerOneUsedSKillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerOneUsedSKillLabel.Location = new System.Drawing.Point(199, 88);
            this.PlayerOneUsedSKillLabel.Name = "PlayerOneUsedSKillLabel";
            this.PlayerOneUsedSKillLabel.Size = new System.Drawing.Size(0, 29);
            this.PlayerOneUsedSKillLabel.TabIndex = 3;
            // 
            // PlayerTwoUsedSKillLabel
            // 
            this.PlayerTwoUsedSKillLabel.AutoSize = true;
            this.PlayerTwoUsedSKillLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PlayerTwoUsedSKillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerTwoUsedSKillLabel.Location = new System.Drawing.Point(990, 88);
            this.PlayerTwoUsedSKillLabel.Name = "PlayerTwoUsedSKillLabel";
            this.PlayerTwoUsedSKillLabel.Size = new System.Drawing.Size(0, 29);
            this.PlayerTwoUsedSKillLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(814, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Applied Skill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Applied Skill";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.ErrorImage = global::MyGracesApp.Properties.Resources.giphy;
            this.pictureBox1.Image = global::MyGracesApp.Properties.Resources.matrix;
            this.pictureBox1.InitialImage = global::MyGracesApp.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(473, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MyGracesApp.Properties.Resources.super_ninja_png;
            this.pictureBox2.Location = new System.Drawing.Point(242, 478);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 204);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MyGracesApp.Properties.Resources.blog_image_ninja;
            this.pictureBox3.Location = new System.Drawing.Point(826, 469);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(389, 256);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // PlayerOneItemLabel
            // 
            this.PlayerOneItemLabel.AutoSize = true;
            this.PlayerOneItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerOneItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.PlayerOneItemLabel.ForeColor = System.Drawing.Color.White;
            this.PlayerOneItemLabel.Location = new System.Drawing.Point(24, 200);
            this.PlayerOneItemLabel.Name = "PlayerOneItemLabel";
            this.PlayerOneItemLabel.Size = new System.Drawing.Size(0, 26);
            this.PlayerOneItemLabel.TabIndex = 10;
            // 
            // PlayerTwoItemLabel
            // 
            this.PlayerTwoItemLabel.AutoSize = true;
            this.PlayerTwoItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTwoItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.PlayerTwoItemLabel.ForeColor = System.Drawing.Color.White;
            this.PlayerTwoItemLabel.Location = new System.Drawing.Point(851, 196);
            this.PlayerTwoItemLabel.Name = "PlayerTwoItemLabel";
            this.PlayerTwoItemLabel.Size = new System.Drawing.Size(0, 26);
            this.PlayerTwoItemLabel.TabIndex = 11;
            // 
            // PlayerOneCodingSpeed
            // 
            this.PlayerOneCodingSpeed.AutoSize = true;
            this.PlayerOneCodingSpeed.BackColor = System.Drawing.Color.Transparent;
            this.PlayerOneCodingSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerOneCodingSpeed.ForeColor = System.Drawing.Color.White;
            this.PlayerOneCodingSpeed.Location = new System.Drawing.Point(178, 9);
            this.PlayerOneCodingSpeed.Name = "PlayerOneCodingSpeed";
            this.PlayerOneCodingSpeed.Size = new System.Drawing.Size(0, 29);
            this.PlayerOneCodingSpeed.TabIndex = 12;
            // 
            // PlayerTwoCodingSpeed
            // 
            this.PlayerTwoCodingSpeed.AutoSize = true;
            this.PlayerTwoCodingSpeed.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTwoCodingSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerTwoCodingSpeed.ForeColor = System.Drawing.Color.White;
            this.PlayerTwoCodingSpeed.Location = new System.Drawing.Point(1018, 13);
            this.PlayerTwoCodingSpeed.Name = "PlayerTwoCodingSpeed";
            this.PlayerTwoCodingSpeed.Size = new System.Drawing.Size(0, 29);
            this.PlayerTwoCodingSpeed.TabIndex = 13;
            // 
            // POneName
            // 
            this.POneName.AutoSize = true;
            this.POneName.BackColor = System.Drawing.Color.Transparent;
            this.POneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.POneName.ForeColor = System.Drawing.Color.White;
            this.POneName.Location = new System.Drawing.Point(14, 9);
            this.POneName.Name = "POneName";
            this.POneName.Size = new System.Drawing.Size(0, 29);
            this.POneName.TabIndex = 14;
            // 
            // PTwoName
            // 
            this.PTwoName.AutoSize = true;
            this.PTwoName.BackColor = System.Drawing.Color.Transparent;
            this.PTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PTwoName.ForeColor = System.Drawing.Color.White;
            this.PTwoName.Location = new System.Drawing.Point(821, 9);
            this.PTwoName.Name = "PTwoName";
            this.PTwoName.Size = new System.Drawing.Size(0, 29);
            this.PTwoName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(14, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Items in use";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(828, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Items in use";
            // 
            // PlayerOneComment
            // 
            this.PlayerOneComment.AutoSize = true;
            this.PlayerOneComment.BackColor = System.Drawing.Color.Transparent;
            this.PlayerOneComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlayerOneComment.ForeColor = System.Drawing.Color.White;
            this.PlayerOneComment.Location = new System.Drawing.Point(434, 478);
            this.PlayerOneComment.Name = "PlayerOneComment";
            this.PlayerOneComment.Size = new System.Drawing.Size(0, 25);
            this.PlayerOneComment.TabIndex = 18;
            // 
            // PlayerTwoComment
            // 
            this.PlayerTwoComment.AutoSize = true;
            this.PlayerTwoComment.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTwoComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlayerTwoComment.ForeColor = System.Drawing.Color.White;
            this.PlayerTwoComment.Location = new System.Drawing.Point(761, 478);
            this.PlayerTwoComment.Name = "PlayerTwoComment";
            this.PlayerTwoComment.Size = new System.Drawing.Size(0, 25);
            this.PlayerTwoComment.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MyGracesApp.Properties.Resources._1palm_beach_and_boats;
            this.ClientSize = new System.Drawing.Size(1282, 708);
            this.Controls.Add(this.PlayerTwoComment);
            this.Controls.Add(this.PlayerOneComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PTwoName);
            this.Controls.Add(this.POneName);
            this.Controls.Add(this.PlayerTwoCodingSpeed);
            this.Controls.Add(this.PlayerOneCodingSpeed);
            this.Controls.Add(this.PlayerTwoItemLabel);
            this.Controls.Add(this.PlayerOneItemLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerTwoUsedSKillLabel);
            this.Controls.Add(this.PlayerOneUsedSKillLabel);
            this.Controls.Add(this.PlayerTwoPBar);
            this.Controls.Add(this.FightButton);
            this.Controls.Add(this.PlayerOnePBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PlayerOnePBar;
        private System.Windows.Forms.Button FightButton;
        private System.Windows.Forms.ProgressBar PlayerTwoPBar;
        private System.Windows.Forms.Label PlayerOneUsedSKillLabel;
        private System.Windows.Forms.Label PlayerTwoUsedSKillLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label PlayerOneItemLabel;
        private System.Windows.Forms.Label PlayerTwoItemLabel;
        private System.Windows.Forms.Label PlayerOneCodingSpeed;
        private System.Windows.Forms.Label PlayerTwoCodingSpeed;
        private System.Windows.Forms.Label POneName;
        private System.Windows.Forms.Label PTwoName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PlayerOneComment;
        private System.Windows.Forms.Label PlayerTwoComment;
    }
}

