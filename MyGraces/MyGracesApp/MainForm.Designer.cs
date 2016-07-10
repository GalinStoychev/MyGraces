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
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerOnePBar
            // 
            this.PlayerOnePBar.BackColor = System.Drawing.SystemColors.Window;
            this.PlayerOnePBar.Location = new System.Drawing.Point(12, 27);
            this.PlayerOnePBar.Name = "PlayerOnePBar";
            this.PlayerOnePBar.Size = new System.Drawing.Size(450, 50);
            this.PlayerOnePBar.TabIndex = 0;
            // 
            // FightButton
            // 
            this.FightButton.BackColor = System.Drawing.Color.Crimson;
            this.FightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.FightButton.ForeColor = System.Drawing.SystemColors.Window;
            this.FightButton.Location = new System.Drawing.Point(576, 27);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(145, 50);
            this.FightButton.TabIndex = 1;
            this.FightButton.Text = "Fight";
            this.FightButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.FightButton.UseVisualStyleBackColor = false;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // PlayerTwoPBar
            // 
            this.PlayerTwoPBar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PlayerTwoPBar.Location = new System.Drawing.Point(819, 27);
            this.PlayerTwoPBar.Name = "PlayerTwoPBar";
            this.PlayerTwoPBar.Size = new System.Drawing.Size(450, 50);
            this.PlayerTwoPBar.TabIndex = 2;
            // 
            // PlayerOneUsedSKillLabel
            // 
            this.PlayerOneUsedSKillLabel.AutoSize = true;
            this.PlayerOneUsedSKillLabel.BackColor = System.Drawing.Color.Fuchsia;
            this.PlayerOneUsedSKillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerOneUsedSKillLabel.Location = new System.Drawing.Point(199, 88);
            this.PlayerOneUsedSKillLabel.Name = "PlayerOneUsedSKillLabel";
            this.PlayerOneUsedSKillLabel.Size = new System.Drawing.Size(0, 39);
            this.PlayerOneUsedSKillLabel.TabIndex = 3;
            // 
            // PlayerTwoUsedSKillLabel
            // 
            this.PlayerTwoUsedSKillLabel.AutoSize = true;
            this.PlayerTwoUsedSKillLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.PlayerTwoUsedSKillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerTwoUsedSKillLabel.Location = new System.Drawing.Point(996, 88);
            this.PlayerTwoUsedSKillLabel.Name = "PlayerTwoUsedSKillLabel";
            this.PlayerTwoUsedSKillLabel.Size = new System.Drawing.Size(0, 39);
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
            this.pictureBox2.Location = new System.Drawing.Point(132, 392);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 204);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MyGracesApp.Properties.Resources.blog_image_ninja;
            this.pictureBox3.Location = new System.Drawing.Point(856, 368);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(389, 256);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MyGracesApp.Properties.Resources._1palm_beach_and_boats;
            this.ClientSize = new System.Drawing.Size(1282, 708);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
    }
}

